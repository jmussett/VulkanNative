using System.Runtime.CompilerServices;
using System.Text;

namespace VulkanNative.Examples.Common.Utility;

public unsafe readonly struct UnmanagedUtf8StringSegment
{
    private readonly int _length;
    private readonly unsafe byte* _pointer;

    public readonly byte* Pointer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _pointer;
    }

    public readonly int Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _length;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnmanagedUtf8StringSegment(byte* pointer, int length)
    {
        _pointer = pointer;
        _length = length;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Span<byte> AsSpan()
    {
        return new(Pointer, Length);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnmanagedString ToUnmanagedString()
    {
        return new(Pointer, Length, Encoding.UTF8);
    }

    public int GetCharCount()
    {
        return Encoding.UTF8.GetNullTerminatingCharCount(AsSpan());
    }

    public int GetChars(Span<char> chars)
    {
        var nullTermByteCount = Encoding.UTF8.FindNullTerminator(AsSpan());

        return Encoding.UTF8.GetChars(AsSpan()[..nullTermByteCount], chars);
    }

    public override string ToString()
    {
        var charCount = GetCharCount();

        return Encoding.UTF8.GetString(AsSpan()[..charCount]);
    }
}
