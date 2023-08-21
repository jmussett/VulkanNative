using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;

namespace VulkanNative.Examples.HelloTriangle;

public unsafe struct UnmanagedString : IUnmanaged<char>
{
    private UnmanagedBuffer<char> _characters;

    public char this[int i]
    { 
        get => _characters[i]; 
        set => _characters[i] = value;
    }

    public readonly int Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _characters.Length;
    }

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnmanagedString(byte* value, int maxCount) : this(value, maxCount, Encoding.UTF8)
    {
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnmanagedString(byte* value, int maxCount, Encoding encoding)
    {
        if (value == (byte*)nint.Zero) throw new ArgumentNullException(nameof(value));
        if (maxCount <= 0) throw new ArgumentOutOfRangeException(nameof(maxCount));

        int nullTermByteCount = FindNullTerminator(value, maxCount, encoding);

        var stringBytes = new ReadOnlySpan<byte>(value, nullTermByteCount);

        var charCount = encoding.GetCharCount(value, nullTermByteCount);

        _characters = new UnmanagedBuffer<char>(charCount);

        encoding.GetChars(stringBytes, _characters.AsSpan());
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly Span<char> AsSpan()
    {
        return _characters.AsSpan();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly char* AsPointer()
    {
        return _characters.AsPointer();
    }

    public override readonly string ToString()
    {
        return _characters.AsSpan().ToString();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void TransferOwnership(ref char* destination)
    {
        _characters.TransferOwnership(ref destination);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public readonly void Dispose()
    {
        _characters.Dispose();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static int FindNullTerminator(byte* value, int maxCount, Encoding encoding)
    {
        if (encoding == Encoding.UTF32)
        {
            for (int i = 0; i < maxCount - 3; i += 4)
            {
                if (*(uint*)(value + i) == 0)
                {
                    return i;
                }
            }
        }
        else if (encoding == Encoding.Unicode || encoding == Encoding.BigEndianUnicode)
        {
            for (int i = 0; i < maxCount - 1; i += 2)
            {
                if (*(ushort*)(value + i) == 0)
                {
                    return i;
                }
            }
        }
        else // For single byte encodings like UTF-8, ASCII
        {
            for (int i = 0; i < maxCount; i++)
            {
                if (value[i] == 0)
                {
                    return i;
                }
            }
        }

        throw new ArgumentException("No null terminator found within the given maxCount.", nameof(value));
    }

    public IEnumerator<char> GetEnumerator()
    {
        return _characters.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
