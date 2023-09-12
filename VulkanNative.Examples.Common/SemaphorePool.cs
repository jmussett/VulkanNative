namespace VulkanNative.Examples.Common;

public sealed class SemaphorePool : IDisposable
{
    private readonly VulkanDevice _device;
    private readonly Queue<VulkanSemaphore> _recycledSemaphores = new();

    public SemaphorePool(VulkanDevice device)
    {
        _device = device;
    }

    public VulkanSemaphore GetSemaphore()
    {
        if (_recycledSemaphores.Count > 0)
            return _recycledSemaphores.Dequeue();

        // If no recycled semaphore is available, create a new one.
        return _device.CreateSemaphore();
    }

    public void Return(VulkanSemaphore semaphore)
    {
        _recycledSemaphores.Enqueue(semaphore);
    }

    public void Dispose()
    {
        while (_recycledSemaphores.Count > 0)
        {
            var semaphore = _recycledSemaphores.Dequeue();
            semaphore.Dispose();
        }
    }
}
