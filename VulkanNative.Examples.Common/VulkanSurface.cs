using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public sealed unsafe class VulkanSurface : IDisposable
{
    private VkSurfaceKHR _handle;
    private readonly VkInstance _instanceHandle;
    private readonly VkKhrSurfaceExtension _surfaceExtension;

    public nint Handle => _handle;

    public VulkanSurface(VkSurfaceKHR handle, VkInstance instanceHandle, VkKhrSurfaceExtension surfaceExtension)
    {
        _handle = handle;
        _instanceHandle = instanceHandle;
        _surfaceExtension = surfaceExtension;
    }

    public bool SupportsDeviceQueueFamily(PhysicalDevice device, uint queueFamilyIndex)
    {
        VkBool32 supported;

        _surfaceExtension.vkGetPhysicalDeviceSurfaceSupportKHR(device.Handle, queueFamilyIndex, _handle, &supported).ThrowOnError();

        return supported == 1;
    }

    public VkSurfaceCapabilitiesKHR GetCapabilities(PhysicalDevice device)
    {
        VkSurfaceCapabilitiesKHR capabilities;
        _surfaceExtension.vkGetPhysicalDeviceSurfaceCapabilitiesKHR(device.Handle, _handle, &capabilities).ThrowOnError();

        return capabilities;
    }

    public VkPresentModeKHR[] GetPresentModes(PhysicalDevice device)
    {
        uint count;
        _surfaceExtension.vkGetPhysicalDeviceSurfacePresentModesKHR(device.Handle, _handle, &count, null).ThrowOnError();

        var presentModePtr = stackalloc VkPresentModeKHR[(int)count];
        _surfaceExtension.vkGetPhysicalDeviceSurfacePresentModesKHR(device.Handle, _handle, &count, presentModePtr).ThrowOnError();

        var presentModes = new VkPresentModeKHR[(int)count];

        for (var i = 0; i < count; i++)
        {
            presentModes[i] = presentModePtr[i];
        }

        return presentModes;
    }

    public VkSurfaceFormatKHR[] GetSurfaceFormats(PhysicalDevice device)
    {
        uint count;
        _surfaceExtension.vkGetPhysicalDeviceSurfaceFormatsKHR(device.Handle, _handle, &count, null).ThrowOnError();

        var sufaceFormatsPtr = stackalloc VkSurfaceFormatKHR[(int)count];
        _surfaceExtension.vkGetPhysicalDeviceSurfaceFormatsKHR(device.Handle, _handle, &count, sufaceFormatsPtr).ThrowOnError();

        var sufaceFormats = new VkSurfaceFormatKHR[(int)count];

        for (var i = 0; i < count; i++)
        {
            sufaceFormats[i] = sufaceFormatsPtr[i];
        }

        return sufaceFormats;
    }

    public void Dispose()
    {
        if (_handle == nint.Zero)
        {
            return;
        }

        _surfaceExtension.vkDestroySurfaceKHR(_instanceHandle, _handle, null);
        _handle = nint.Zero;

        GC.SuppressFinalize(this);
    }

    ~VulkanSurface()
    {
        Dispose();
    }
}

