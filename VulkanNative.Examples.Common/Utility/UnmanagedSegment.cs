using System.Reflection;
using System.Runtime.CompilerServices;

namespace VulkanNative.Examples.Common.Utility;

public unsafe readonly struct UnmanagedSegment<T> where T : unmanaged
{
    private readonly int _length;
    private readonly unsafe T* _pointer;

    public readonly int Length
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _length;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public UnmanagedSegment(T* pointer, int length)
    {
        _pointer = pointer;
        _length = length;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public T* AsPointer()
    {
        return _pointer;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Span<T> AsSpan()
    {
        return new(_pointer, Length);
    }

    public override string ToString()
    {
        return AsSpan().ToString();
    }
}