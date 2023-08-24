using System.Runtime.CompilerServices;

namespace VulkanNative.Examples.HelloTriangle;

public unsafe readonly struct UnmanagedSegment<T> where T : unmanaged
{
    private readonly int _length;
    private readonly unsafe T* _pointer;

    public readonly T* Pointer
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
    public UnmanagedSegment(T* pointer, int length)
    {
        _pointer = pointer;
        _length = length;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Span<T> AsSpan()
    {
        return new(Pointer, Length);
    }

    public override string ToString()
    {
        return AsSpan().ToString();
    }
}