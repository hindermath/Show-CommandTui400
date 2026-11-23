using System;
using System.Collections.Concurrent;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;

namespace Hindermath.ShowCommandTui400.Bootstrap
{
    // DE: Nur das Modul teilt seine PowerShell-API mit dem Host. NuGet-Bibliotheken bleiben privat.
    // EN: Only the PowerShell API is shared with the host. NuGet libraries remain private.
    public static class DependencyLoader
    {
        private static readonly ConcurrentDictionary<string, ModuleContext> Contexts =
            new ConcurrentDictionary<string, ModuleContext>(OperatingSystem.IsWindows() ? StringComparer.OrdinalIgnoreCase : StringComparer.Ordinal);

        public static Assembly LoadModule(string assemblyPath)
        {
            string fullPath = Path.GetFullPath(assemblyPath);
            return Contexts.GetOrAdd(fullPath, path => new ModuleContext(path)).LoadMain();
        }

        public static Assembly LoadCompanion(string modulePath, string companionPath)
        {
            string fullPath = Path.GetFullPath(modulePath);
            LoadModule(fullPath);
            return Contexts[fullPath].LoadFromAssemblyPath(Path.GetFullPath(companionPath));
        }

        private sealed class ModuleContext : AssemblyLoadContext
        {
            private readonly string mainPath;
            private readonly string directory;
            private readonly AssemblyDependencyResolver resolver;
            private readonly Lazy<Assembly> main;

            internal ModuleContext(string path) : base("ShowCommandTui400:" + path, false)
            {
                mainPath = path;
                directory = Path.GetDirectoryName(path) + Path.DirectorySeparatorChar;
                resolver = new AssemblyDependencyResolver(path);
                main = new Lazy<Assembly>(() => LoadFromAssemblyPath(mainPath));
            }

            internal Assembly LoadMain() { return main.Value; }

            protected override Assembly Load(AssemblyName name)
            {
                if (name.Name == "System.Management.Automation")
                    return Default.LoadFromAssemblyName(name);

                string path = resolver.ResolveAssemblyToPath(name);
                if (path == null)
                {
                    string candidate = Path.Combine(directory, name.Name + ".dll");
                    if (File.Exists(candidate)) path = candidate;
                }
                if (path != null && Path.GetFullPath(path).StartsWith(directory, OperatingSystem.IsWindows() ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal))
                    return LoadFromAssemblyPath(path);
                return null;
            }

            protected override IntPtr LoadUnmanagedDll(string name)
            {
                string path = resolver.ResolveUnmanagedDllToPath(name);
                if (path != null && Path.GetFullPath(path).StartsWith(directory, OperatingSystem.IsWindows() ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal))
                    return LoadUnmanagedDllFromPath(path);
                return IntPtr.Zero;
            }
        }
    }
}
