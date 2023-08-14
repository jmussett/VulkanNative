using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VulkanNative.Generator;

public static class VariableNameSanitizer
{
    private static HashSet<string> _reservedKeywords = new HashSet<string>
{
    "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class",
    "const", "continue", "decimal", "default", "delegate", "do", "double", "else", "enum", "event",
    "explicit", "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit",
    "in", "int", "interface", "internal", "is", "lock", "long", "namespace", "new", "null", "object",
    "operator", "out", "override", "params", "private", "protected", "public", "readonly", "ref", "return",
    "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch", "this",
    "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual",
    "void", "volatile", "while"
    // ... Add other reserved keywords if necessary
};

    public static string Sanitize(string input)
    {
        if (string.IsNullOrEmpty(input))
            return "_";

        var sanitizedBuilder = new StringBuilder();

        // Ensure it starts with a letter or underscore.
        char firstChar = input[0];
        if (!char.IsLetter(firstChar) && firstChar != '_')
            sanitizedBuilder.Append('_');

        // Ensure the rest of the characters are valid (alphabets, numbers or underscore)
        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c) || c == '_')
            {
                sanitizedBuilder.Append(c);
            }
            else
            {
                sanitizedBuilder.Append('_');
            }
        }

        string sanitized = sanitizedBuilder.ToString();

        // Check against reserved keywords
        if (_reservedKeywords.Contains(sanitized))
            sanitized = "@" + sanitized;

        return sanitized;
    }
}