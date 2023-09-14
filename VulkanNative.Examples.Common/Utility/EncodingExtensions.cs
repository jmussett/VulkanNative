using System;
using System.Runtime.InteropServices;
using System.Text;

namespace VulkanNative.Examples.Common.Utility;

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


    public delegate void BytesDelegate<TState>(Span<byte> span, ref TState state);

    public delegate void BytesDelegate(Span<byte> span);

    public static void GetBytes<TState>(this Encoding encoding, ReadOnlySpan<char> source, ref TState state, BytesDelegate<TState> callback)
    {
        encoding.GetBytes(source, 512, ref state, callback);
    }

    public static void GetBytes<TState>(this Encoding encoding, ReadOnlySpan<char> source, BytesDelegate callback)
    {
        encoding.GetBytes(source, 512, callback);
    }

    public static void GetBytes<TState>(this Encoding encoding, ReadOnlySpan<char> source, int maxSize, ref TState state, BytesDelegate<TState> callback)
    {
        int byteCount = encoding.GetByteCount(source);

        if (byteCount > maxSize)
        {
            throw new ArgumentException($"String '{source}' Exceeds the allowed length of {maxSize}.");
        }

        Span<byte> buffer = stackalloc byte[byteCount];

        encoding.GetBytes(source, buffer);

        callback(buffer, ref state);
    }

    public static void GetBytes(this Encoding encoding, ReadOnlySpan<char> source, int maxSize, BytesDelegate callback)
    {
        int byteCount = encoding.GetByteCount(source);

        if (byteCount > maxSize)
        {
            throw new ArgumentException($"String '{source}' Exceeds the allowed length of {maxSize}.");
        }

        Span<byte> buffer = stackalloc byte[byteCount];

        encoding.GetBytes(source, buffer);

        callback(buffer);
    }
}
