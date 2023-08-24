using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;

namespace VulkanNative.Examples.HelloTriangle;

public unsafe sealed class UnmanagedEncodedString : IUnmanaged<byte>
{
    private readonly UnmanagedBuffer<byte> _bytes;

    public byte this[int i]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _bytes[i];
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set => _bytes[i] = value;
    }

    public int Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _bytes.Length;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnmanagedEncodedString(char* chars, int length) 
        : this(new ReadOnlySpan<char>(chars, length), Encoding.UTF8)
    {
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnmanagedEncodedString(char* chars, int length, Encoding encoding) 
        : this(new ReadOnlySpan<char>(chars, length), encoding)
    {
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnmanagedEncodedString(ReadOnlySpan<char> value) 
        : this(value, Encoding.UTF8)
    {
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnmanagedEncodedString(ReadOnlySpan<char> value, Encoding encoding)
    {
        var length = encoding.GetByteCount(value);
        _bytes = new UnmanagedBuffer<byte>(length + 1); // +1 for null-terminator

        fixed (char* strPtr = value)
        {
            _ = encoding.GetBytes(strPtr, value.Length, _bytes.AsPointer(), length);
        }

        _bytes[length] = 0;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Span<byte> AsSpan()
    {
        return _bytes.AsSpan();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public byte* AsPointer()
    {
        return _bytes.AsPointer();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void TransferOwnership(ref byte* destination)
    {
        _bytes.TransferOwnership(ref destination);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Dispose()
    {
        _bytes.Dispose();
    }

    public IEnumerator<byte> GetEnumerator()
    {
        return _bytes.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public static implicit operator UnmanagedEncodedString(string value)
    {
        return new UnmanagedEncodedString(value.AsSpan());
    }

    public static implicit operator UnmanagedBuffer<byte>(UnmanagedEncodedString value)
    {
        return value._bytes;
    }
}
