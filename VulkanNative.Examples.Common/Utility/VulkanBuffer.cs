using System.Runtime.CompilerServices;

namespace VulkanNative.Examples.Common.Utility;

public sealed unsafe class VulkanBuffer<T> : UnmanagedBuffer<T> where T : unmanaged
{
    public VulkanBuffer(int initialCapacity = 4, bool fixedLength = false)
        : base(initialCapacity, fixedLength)
    { }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new T* AsPointer()
    {
        // If buffers do not have a length, then vulkan demands then get
        // set to "nullptr" as thir would be nothing to point to.

        return Length == 0 ? null : base.AsPointer();
    }
}
