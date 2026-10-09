using System.Globalization;
using System.Text;
namespace ShowCommandTui400.Presentation;

public static class SafeDisplayText
{
    public static string Format(string value)
    {
        ArgumentNullException.ThrowIfNull(value);
        var result = new StringBuilder();
        foreach (var rune in value.EnumerateRunes())
        {
            var category = Rune.GetUnicodeCategory(rune);
            result.Append(category is UnicodeCategory.Control or UnicodeCategory.Format or UnicodeCategory.LineSeparator or UnicodeCategory.ParagraphSeparator ? "?" : rune.ToString());
        }
        return result.ToString();
    }
}
