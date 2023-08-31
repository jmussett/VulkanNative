﻿using VulkanNative.Examples.Common.Utility;

namespace VulkanNative.Examples.Common;

public sealed unsafe class VulkanDevice : IDisposable
{
    private VkDevice _handle;
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
                sType = (VkStructureType)1000001000, // TODO: VkStructureType.VK_STRUCTURE_TYPE_SWAPCHAIN_CREATE_INFO_KHR,
                surface = createInfo.Surface.Handle,
                minImageCount = createInfo.MinImageCount,
                imageExtent = createInfo.ImageExtent,
                imageFormat = createInfo.SurfaceFormat.format,
                imageColorSpace = createInfo.SurfaceFormat.colorSpace,
                imageArrayLayers = createInfo.ImageArrayLayers,
                imageUsage = createInfo.ImageUsage,
                imageSharingMode = createInfo.SharingMode,
                queueFamilyIndexCount = (uint)createInfo.QueueFamilyIndeces.Length,
                pQueueFamilyIndices = (uint*)queueFamilyIndecesPtr,
                preTransform = createInfo.PreTransform,
                compositeAlpha = createInfo.CompositeAlpha,
                presentMode = createInfo.PresentMode,
                clipped = (uint) (createInfo.Clipped ? 1 : 0),
                oldSwapchain = createInfo.OldSwapchain
            };

            VkSwapchainKHR swapchain;


            _swapchainExtension.VkCreateSwapchainKHR(_handle, &createInfoKHR, null, &swapchain).ThrowOnError();

            return new VulkanSwapchain(swapchain, _handle, _swapchainExtension);
        }
    }

    public ImageView CreateImageView(ImageViewCreateInfo createInfo)
    {
        VkImageViewCreateInfo vkCreateInfo = new()
        {
            sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO,
            image = createInfo.Image,
            viewType =createInfo.ViewType,
            format = createInfo.Format,
            components = createInfo.Components,
            subresourceRange = createInfo.SubresourceRange
        };

        VkImageView imageView;

        _commands.VkCreateImageView(_handle, &vkCreateInfo, null, &imageView).ThrowOnError();

        return new ImageView(imageView, _handle, _commands);
    }

    public unsafe ShaderModule CreateShaderModule(byte[] byteCode)
    {
        fixed (byte* byteCodePtr = byteCode)
        {
            var createInfo = new VkShaderModuleCreateInfo
            {
                sType = VkStructureType.VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO,
                pCode = (uint*)byteCodePtr,
                codeSize = new nuint((uint)byteCode.Length)
            };

            VkShaderModule shaderModule;

            _commands.VkCreateShaderModule(_handle, &createInfo, null, &shaderModule).ThrowOnError();

            return new ShaderModule(shaderModule, _handle, _commands);
        }
    }

    public void Dispose()
    {
        if (_handle == nint.Zero)
        {
            return;
        }

        _commands.VkDestroyDevice(_handle, null);
        _handle = nint.Zero;

        GC.SuppressFinalize(this);
    }

    ~VulkanDevice()
    {
        Dispose();
    }
}

public sealed unsafe class ShaderModule : IDisposable
{
    private VkShaderModule _handle;
    private readonly VkDevice _deviceHandle;
    private readonly VkDeviceCommands _commands;

    public ShaderModule(VkShaderModule handle, VkDevice deviceHandle, VkDeviceCommands commands)
    {
        _handle = handle;
        _deviceHandle = deviceHandle;
        _commands = commands;
    }

    public void Dispose()
    {
        if (_handle == nint.Zero)
        {
            return;
        }

        _commands.VkDestroyShaderModule(_deviceHandle, _handle, null);
        _handle = nint.Zero;

        GC.SuppressFinalize(this);
    }

    ~ShaderModule()
    {
        Dispose();
    }
}