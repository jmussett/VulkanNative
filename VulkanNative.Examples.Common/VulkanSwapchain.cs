using System;
using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public sealed unsafe class VulkanSwapchain : IDisposable
{
    private VkSwapchainKHR _handle;
    private readonly VkDevice _deviceHandle;
    private readonly VkKhrSwapchainExtension _swapchainExtension;
    private readonly SwapchainDefinition _swapchainDefinition;

    public nint Handle => _handle;

    public VkExtent2D ImageExtent => _swapchainDefinition.ImageExtent;
    public VkSurfaceFormatKHR SurfaceFormat => _swapchainDefinition.SurfaceFormat;

    public VulkanSwapchain(VkSwapchainKHR handle, VkDevice deviceHandle, SwapchainDefinition definition, VkKhrSwapchainExtension swapchainExtension)
    {
        _handle = handle;
        _deviceHandle = deviceHandle;
        _swapchainDefinition = definition;
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

    public AcquireNextImageResult AquireNextImage(out uint imageIndex, VulkanSemaphore? semaphore = null, VulkanFence? fence = null, uint timeout = uint.MaxValue)
    {
        fixed(uint* imageIndexPtr = &imageIndex)
        {
            imageIndex = 0;

            var result = _swapchainExtension.vkAcquireNextImageKHR(
                _deviceHandle, _handle, timeout,
                semaphore?.Handle ?? nint.Zero, fence?.Handle ?? nint.Zero,
                imageIndexPtr
            );

            return result switch
            {
                VkResult.VK_SUCCESS => AcquireNextImageResult.Success,
                VkResult.VK_SUBOPTIMAL_KHR => AcquireNextImageResult.Suboptimal,
                VkResult.VK_TIMEOUT => AcquireNextImageResult.Timeout,
                VkResult.VK_NOT_READY => AcquireNextImageResult.NotReady,
                VkResult.VK_ERROR_OUT_OF_DATE_KHR => AcquireNextImageResult.OutOfDate,
                _ => throw new InvalidOperationException($"Vulkan Error: {result}")
            };
        } 
        
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
