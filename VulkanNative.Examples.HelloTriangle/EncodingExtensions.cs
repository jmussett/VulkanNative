using System.Runtime.InteropServices;
using System.Text;

namespace VulkanNative.Examples.HelloTriangle;

internal static class EncodingExtensions
{
    public static int GetNullTerminatingCharCount(this Encoding encoding, ReadOnlySpan<byte> bytes)
    {
        int nullTermByteCount = encoding.FindNullTerminator(bytes);

        var stringBytes = bytes[..nullTermByteCount];

        return encoding.GetCharCount(stringBytes);
    }

    public static int FindNullTerminator(this Encoding encoding, ReadOnlySpan<byte> value)
    {
        if (encoding == Encoding.UTF32)
        {
            for (int i = 0; i < value.Length - 3; i += 4)
            {
                // For 4 byte encodings, we read it as a int (or a surrogate pair of chars)
                if (MemoryMarshal.Read<uint>(value[i..]) == 0)
                {
                    return i;
                }
            }
        }
        else if (encoding == Encoding.Unicode || encoding == Encoding.BigEndianUnicode)
        {
            for (int i = 0; i < value.Length - 1; i += 2)
            {
                // For 2 byte encodings, we read it as a ushort (same as char)
                if (MemoryMarshal.Read<ushort>(value[i..]) == 0)
                {
                    return i;
                }
            }
        }
        else
        {
            for (int i = 0; i < value.Length; i++)
            {
                // For single byte encodings like UTF-8, ASCII
                if (value[i] == 0)
                {
                    return i;
                }
            }
        }

        throw new ArgumentException("No null terminator found within the given span.", nameof(value));
    }
}
