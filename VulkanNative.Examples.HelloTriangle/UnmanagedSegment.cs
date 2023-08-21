using System.Diagnostics;

namespace VulkanNative.Examples.HelloTriangle;

public unsafe readonly struct UnmanagedSegment<T> where T : unmanaged
{
    public readonly T* Pointer { get; }
    public readonly int Length { get; }

    public UnmanagedSegment(T* pointer, int length)
    {
        Pointer = pointer;
        Length = length;
    }

    public Span<T> AsSpan() => new(Pointer, Length);

    public override string ToString()
    {
        return AsSpan().ToString();
    }
}