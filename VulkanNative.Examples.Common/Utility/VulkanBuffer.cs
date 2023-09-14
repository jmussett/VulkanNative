using Microsoft.Extensions.ObjectPool;
using System.Runtime.CompilerServices;

namespace VulkanNative.Examples.Common.Utility;

public sealed unsafe class VulkanBuffer<TItem> : UnmanagedBuffer<TItem> where TItem : unmanaged
{
    private static DefaultObjectPool<VulkanBuffer<TItem>> _pool
        = new(new VulkanBufferObjectPolicy());

    private VulkanBuffer() { }

    public new static VulkanBuffer<TItem> Create(int initialCapacity = 4, bool fixedLength = false)
    {
        var buffer = _pool.Get();

        buffer.Initialize(initialCapacity, fixedLength);

        return buffer;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public new TItem* AsPointer()
    {
        // If buffers do not have a length, then vulkan demands then get
        // set to "nullptr" as there would be nothing to point to.

        return Length == 0 ? null : base.AsPointer();
    }

    protected override void Dispose(bool disposing)
    {
        _pool.Return(this);
    }

    private class VulkanBufferObjectPolicy : IPooledObjectPolicy<VulkanBuffer<TItem>>
    {
        public VulkanBuffer<TItem> Create() => new();
        public bool Return(VulkanBuffer<TItem> buffer)
        {
            // Make sure the buffer is reset before returning
            buffer.Reset();

            return true;
        }
    }
}
