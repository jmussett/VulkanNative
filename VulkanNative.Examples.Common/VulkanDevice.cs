using VulkanNative.Examples.Common.Utility;

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


            _swapchainExtension.vkCreateSwapchainKHR(_handle, &createInfoKHR, null, &swapchain).ThrowOnError();

            return new VulkanSwapchain(swapchain, _handle, _swapchainExtension);
        }
    }

    public ImageView CreateImageView(ImageViewCreateInfo createInfo)
    {
        VkImageViewCreateInfo vkCreateInfo = new()
        {
            image = createInfo.Image,
            viewType =createInfo.ViewType,
            format = createInfo.Format,
            components = createInfo.Components,
            subresourceRange = createInfo.SubresourceRange
        };

        VkImageView imageView;

        _commands.vkCreateImageView(_handle, &vkCreateInfo, null, &imageView).ThrowOnError();

        return new ImageView(imageView, _handle, _commands);
    }

    public unsafe ShaderModule CreateShaderModule(byte[] byteCode)
    {
        fixed (byte* byteCodePtr = byteCode)
        {
            VkShaderModuleCreateInfo createInfo = new()
            {
                pCode = (uint*)byteCodePtr,
                codeSize = new nuint((uint)byteCode.Length)
            };

            VkShaderModule shaderModule;

            _commands.vkCreateShaderModule(_handle, &createInfo, null, &shaderModule).ThrowOnError();

            return new ShaderModule(shaderModule, _handle, _commands);
        }
    }

    public PipelineLayout CreatePipelineLayout(VkDescriptorSetLayout[]? setLayouts = null, VkPushConstantRange[]? pushConstantRanges = null)
    {
        fixed (VkDescriptorSetLayout* setLayoutsPtr = setLayouts)
        fixed (VkPushConstantRange* pushConstantRangesPtr = pushConstantRanges)
        {
            VkPipelineLayoutCreateInfo vkCreateInfo = new()
            {
                pSetLayouts = setLayouts != null ? setLayoutsPtr : null,
                setLayoutCount = (uint)(setLayouts?.Length ?? 0),

                pPushConstantRanges = pushConstantRanges != null ? pushConstantRangesPtr : null,
                pushConstantRangeCount = (uint)(pushConstantRanges?.Length ?? 0),
            };

            VkPipelineLayout pipelineLayout;

            _commands.vkCreatePipelineLayout(_handle, &vkCreateInfo, null, &pipelineLayout);

            return new PipelineLayout(pipelineLayout, _handle, _commands);
        }
    }

    public RenderPass CreateRenderPass(SubpassDescription[] subpassDescriptions, VkAttachmentDescription[] colorAttachments)
    {
        fixed (VkAttachmentDescription* colorAttachmentPtr = colorAttachments)
        {
            var subpassesPtr = stackalloc VkSubpassDescription[subpassDescriptions.Length];

            for(var i = 0; i < subpassDescriptions.Length; i++)
            {
                subpassesPtr[i] = new()
                {
                    pipelineBindPoint = subpassDescriptions[i].BindPoint,
                    inputAttachmentCount = (uint) subpassDescriptions[i].InputAttachments.Length,
                    pInputAttachments = subpassDescriptions[i].InputAttachments.AsPointer(),
                    colorAttachmentCount = (uint)subpassDescriptions[i].ColorAttachments.Length,
                    pColorAttachments = subpassDescriptions[i].ColorAttachments.AsPointer(),
                    pResolveAttachments = subpassDescriptions[i].ResolveReferences.AsPointer(),
                    preserveAttachmentCount = (uint) subpassDescriptions[i].PreserveAttachments.Length,
                    pPreserveAttachments = subpassDescriptions[i].PreserveAttachments.AsPointer(),
                };

                if (subpassDescriptions[i].DepthStencilAttachment.HasValue)
                {
                    var a = subpassDescriptions[i].DepthStencilAttachment!.Value;
                    subpassesPtr[i].pDepthStencilAttachment = &a;
                }
            }

            VkRenderPassCreateInfo renderPassInfo = new()
            {
                attachmentCount = (uint) colorAttachments.Length,
                pAttachments = colorAttachmentPtr,
                subpassCount = (uint) subpassDescriptions.Length,
                pSubpasses = subpassesPtr
            };

            VkRenderPass renderPass;

            _commands.vkCreateRenderPass(_handle, &renderPassInfo, null, &renderPass).ThrowOnError();

            return new RenderPass(renderPass, _handle, _commands);
        }
    }

    public void Dispose()
    {
        if (_handle == nint.Zero)
        {
            return;
        }

        _commands.vkDestroyDevice(_handle, null);
        _handle = nint.Zero;

        GC.SuppressFinalize(this);
    }

    ~VulkanDevice()
    {
        Dispose();
    }
}