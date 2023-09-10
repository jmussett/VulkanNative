using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public sealed unsafe class VulkanSwapchain : IDisposable
{
    private VkSwapchainKHR _handle;
    private readonly VkDevice _deviceHandle;
    private readonly VkKhrSwapchainExtension _swapchainExtension;

    public nint Handle => _handle;

    public VulkanSwapchain(VkSwapchainKHR handle, VkDevice deviceHandle, VkKhrSwapchainExtension swapchainExtension)
    {
        _handle = handle;
        _deviceHandle = deviceHandle;
        _swapchainExtension = swapchainExtension;
    }

    public VkImage[] GetImages()
    {
        uint count;
        _swapchainExtension.vkGetSwapchainImagesKHR(_deviceHandle, _handle, &count, null);

        var imagesPtr = stackalloc VkImage[(int)count];

        _swapchainExtension.vkGetSwapchainImagesKHR(_deviceHandle, _handle, &count, imagesPtr);

        var images = new VkImage[(int)count];

        for (var i = 0; i < count; i++)
        {
            images[i] = imagesPtr[i];
        }

        return images;
    }

    public uint AquireNextImage(VulkanSemaphore? semaphore = null, VulkanFence? fence = null, uint timeout = uint.MaxValue)
    {
        uint imageIndex;

        _swapchainExtension.vkAcquireNextImageKHR(
            _deviceHandle, _handle, timeout, 
            semaphore?.Handle ?? nint.Zero, fence?.Handle ?? nint.Zero, 
            &imageIndex
        ).ThrowOnError();

        return imageIndex;
    }


    public void Dispose()
    {
        if (_handle == nint.Zero)
        {
            return;
        }

        _swapchainExtension.vkDestroySwapchainKHR(_deviceHandle, _handle, null);
        _handle = nint.Zero;

        GC.SuppressFinalize(this);
    }

    ~VulkanSwapchain()
    {
        Dispose();
    }
}