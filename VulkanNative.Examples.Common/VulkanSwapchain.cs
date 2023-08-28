namespace VulkanNative.Examples.Common;

public sealed unsafe class VulkanSwapchain : IDisposable
{
    private VkSwapchainKHR _handle;
    private VkDevice _deviceHandle;
    private readonly VkKhrSwapchainExtension _swapchainExtension;

    public VulkanSwapchain(VkSwapchainKHR handle, VkDevice deviceHandle, VkKhrSwapchainExtension swapchainExtension)
    {
        _handle = handle;
        _deviceHandle = deviceHandle;
        _swapchainExtension = swapchainExtension;
    }

    public VkImage[] GetImages()
    {
        uint count;
        _swapchainExtension.VkGetSwapchainImagesKHR(_deviceHandle, _handle, &count, null);

        var imagesPtr = stackalloc VkImage[(int)count];

        _swapchainExtension.VkGetSwapchainImagesKHR(_deviceHandle, _handle, &count, imagesPtr);

        var images = new VkImage[(int)count];

        for (var i = 0; i < count; i++)
        {
            images[i] = imagesPtr[i];
        }

        return images;
    }

    public void Dispose()
    {
        _swapchainExtension.VkDestroySwapchainKHR(_deviceHandle, _handle, null);
    }
}