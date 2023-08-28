using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public sealed unsafe class VulkanDevice : IDisposable
{
    private readonly VkDevice _handle;
    private readonly VulkanLoader _loader;
    private readonly VkDeviceCommands _commands;
    private readonly VkKhrSwapchainExtension _swapchainExtension;

    public nint Handle => _handle;

    public VulkanDevice(VkDevice handle, VulkanLoader loader)
    {
        _handle = handle;

        _loader = loader;
        _commands = loader.LoadDeviceCommands(Handle);

        _swapchainExtension = _loader.Extensions.LoadVkKhrSwapchainExtension(_handle);
    }

    public unsafe VulkanSwapchain CreateSwapchain(SwapchainCreateInfo createInfo)
    {
        fixed (void* queueFamilyIndecesPtr = createInfo.QueueFamilyIndeces)
        {
            VkSwapchainCreateInfoKHR createInfoKHR = new()
            {
                SType = (VkStructureType)1000001000, // FIX: VkStructureType.VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR,
                Surface = createInfo.Surface.Handle,
                MinImageCount = createInfo.MinImageCount,
                ImageExtent = createInfo.ImageExtent,
                ImageFormat = createInfo.SurfaceFormat.Format,
                ImageColorSpace = createInfo.SurfaceFormat.ColorSpace,
                ImageArrayLayers = createInfo.ImageArrayLayers,
                ImageUsage = createInfo.ImageUsage,
                ImageSharingMode = createInfo.SharingMode,
                QueueFamilyIndexCount = (uint)createInfo.QueueFamilyIndeces.Length,
                PQueueFamilyIndices = (uint*)queueFamilyIndecesPtr,
                PreTransform = createInfo.PreTransform,
                CompositeAlpha = createInfo.CompositeAlpha,
                PresentMode = createInfo.PresentMode,
                Clipped = (uint) (createInfo.Clipped ? 1 : 0),
                OldSwapchain = createInfo.OldSwapchain
            };

            VkSwapchainKHR swapchain;


            _swapchainExtension.VkCreateSwapchainKHR(_handle, &createInfoKHR, null, &swapchain).ThrowOnError();

            return new VulkanSwapchain(swapchain, _handle, _swapchainExtension);
        }
    }

    public void Dispose()
    {
        _commands.VkDestroyDevice(Handle, null);
    }
}
