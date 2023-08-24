using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;

namespace VulkanNative.Examples.HelloTriangle;

public unsafe sealed class UnmanagedString : IUnmanaged<char>
{
    private UnmanagedBuffer<char> _characters;

    public char this[int i]
    { 
        get => _characters[i]; 
        set => _characters[i] = value;
    }

    public int Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _characters.Length;
    }

    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnmanagedString(byte* value, int maxCount)
        : this(value, maxCount, Encoding.UTF8)
    {
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnmanagedString(byte* value, int maxCount, Encoding encoding)
        : this(new ReadOnlySpan<byte>(value, maxCount), encoding)
    {
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnmanagedString(ReadOnlySpan<byte> bytes)
        : this(bytes, Encoding.UTF8)
    {
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnmanagedString(ReadOnlySpan<byte> bytes, Encoding encoding)
    {
        var charCount = encoding.GetNullTerminatingCharCount(bytes);

        _characters = new UnmanagedBuffer<char>(charCount);

        encoding.GetChars(bytes[..charCount], _characters.AsSpan());
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Span<char> AsSpan()
    {
        return _characters.AsSpan();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public char* AsPointer()
    {
        return _characters.AsPointer();
    }

    public override string ToString()
    {
        return _characters.AsSpan().ToString();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void TransferOwnership(ref char* destination)
    {
        _characters.TransferOwnership(ref destination);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void Dispose()
    {
        _characters.Dispose();
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
