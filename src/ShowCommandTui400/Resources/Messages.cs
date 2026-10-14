using System.Globalization;
using System.Resources;
namespace ShowCommandTui400.Resources;

internal static class Messages
{
    private static readonly ResourceManager Resource = new("ShowCommandTui400.Resources.Messages", typeof(Messages).Assembly);
    internal static IEnumerable<string> Keys => Resource.GetResourceSet(CultureInfo.GetCultureInfo("de"), true, false)!.Cast<System.Collections.DictionaryEntry>().Select(p => (string)p.Key);
    internal static string InLanguage(string key, string language) => Resource.GetString(key, CultureInfo.GetCultureInfo(language)) ?? throw new InvalidOperationException("Missing resource: " + key);
    internal static string Both(string key) => InLanguage(key, "de") + " / " + InLanguage(key, "en");
}
