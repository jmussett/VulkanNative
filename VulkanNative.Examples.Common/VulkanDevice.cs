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

    public VulkanQueue GetQueue(uint queueFamilyIndex, uint queueIndex)
    {
        VkQueue queue;

        _commands.vkGetDeviceQueue(_handle, queueFamilyIndex, queueIndex, &queue);

        return new VulkanQueue(queue, _commands, _swapchainExtension);
    }

    public unsafe VulkanSwapchain CreateSwapchain(SwapchainDefinition definition)
    {
        fixed (void* queueFamilyIndecesPtr = definition.QueueFamilyIndeces)
        {
            VkSwapchainCreateInfoKHR createInfoKHR = new()
            {
                surface = definition.Surface.Handle,
                minImageCount = definition.MinImageCount,
                imageExtent = definition.ImageExtent,
                imageFormat = definition.SurfaceFormat.format,
                imageColorSpace = definition.SurfaceFormat.colorSpace,
                imageArrayLayers = definition.ImageArrayLayers,
                imageUsage = definition.ImageUsage,
                imageSharingMode = definition.SharingMode,
                queueFamilyIndexCount = (uint)definition.QueueFamilyIndeces.Length,
                pQueueFamilyIndices = (uint*)queueFamilyIndecesPtr,
                preTransform = definition.PreTransform,
                compositeAlpha = definition.CompositeAlpha,
                presentMode = definition.PresentMode,
                clipped = (uint) (definition.Clipped ? 1 : 0),
                oldSwapchain = definition.OldSwapchain
            };

            VkSwapchainKHR swapchain;

            _swapchainExtension.vkCreateSwapchainKHR(_handle, &createInfoKHR, null, &swapchain).ThrowOnError();

            return new VulkanSwapchain(swapchain, _handle, definition, _swapchainExtension);
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

    public RenderPass CreateRenderPass(SubpassDescription[] subpassDescriptions, VkAttachmentDescription[] colorAttachments, VkSubpassDependency[] dependancies)
    {
        fixed(VkSubpassDependency* dependancyPtr = dependancies)
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
                pSubpasses = subpassesPtr,
                dependencyCount = (uint) dependancies.Length,
                pDependencies = dependancyPtr
            };

            VkRenderPass renderPass;

            _commands.vkCreateRenderPass(_handle, &renderPassInfo, null, &renderPass).ThrowOnError();

            return new RenderPass(renderPass, _handle, _commands);
        }
    }

    public Pipeline[] CreateGraphicsPipelines(GraphicsPipelineDefinition[] pipelineDefitions)
    {
        var pipelineCache = new VkPipelineCache(nint.Zero);

        VkGraphicsPipelineCreateInfo* vkCreateInfosPtr = stackalloc VkGraphicsPipelineCreateInfo[pipelineDefitions.Length];

        using UnmanagedJaggedArray<VkPipelineDynamicStateCreateInfo> dynamicStates = new();
        using UnmanagedJaggedArray<VkPipelineVertexInputStateCreateInfo> vertextInputStates = new();
        using UnmanagedJaggedArray<VkPipelineInputAssemblyStateCreateInfo> inputAssemblyStates = new();
        using UnmanagedJaggedArray<VkPipelineShaderStageCreateInfo> stages = new();
        using UnmanagedJaggedArray<VkPipelineViewportStateCreateInfo> viewportStates = new();
        using UnmanagedJaggedArray<VkPipelineRasterizationStateCreateInfo> rasterizationStates = new();
        using UnmanagedJaggedArray<VkPipelineMultisampleStateCreateInfo> multisampleStates = new();
        using UnmanagedJaggedArray<VkPipelineColorBlendStateCreateInfo> colorBlendStates = new();
        using UnmanagedJaggedArray<VkPipelineColorBlendAttachmentState> colorBlendAttachmentStates = new();

        // We allocate the nullable types first so they're lifetime is preserved until after vkCreateGraphicsPipelines is called.
        for (var i = 0; i < pipelineDefitions.Length; i++)
        {
            VkPipelineVertexInputStateCreateInfo? vertextInputStateCreateInfo =
                pipelineDefitions[i].VertexInputState is not null
                    ? new()
                    {
                        vertexAttributeDescriptionCount = (uint)pipelineDefitions[i].VertexInputState!.VertexAttributeDescriptions.Length,
                        pVertexAttributeDescriptions = pipelineDefitions[i].VertexInputState!.VertexAttributeDescriptions.AsPointer(),
                        vertexBindingDescriptionCount = (uint)pipelineDefitions[i].VertexInputState!.VertexBindingDescriptions.Length,
                        pVertexBindingDescriptions = pipelineDefitions[i].VertexInputState!.VertexBindingDescriptions.AsPointer()
                    }
                    : null;

            vertextInputStates.Add(vertextInputStateCreateInfo);

            VkPipelineDynamicStateCreateInfo? dynamicStateCreateInfo =
                pipelineDefitions[i].DynamicStates.Length != 0
                    ? new()
                    {
                        dynamicStateCount = (uint)pipelineDefitions[i].DynamicStates.Length,
                        pDynamicStates = pipelineDefitions[i].DynamicStates.AsPointer()
                    }
                    : null;

            dynamicStates.Add(dynamicStateCreateInfo);

            VkPipelineInputAssemblyStateCreateInfo? inputAssemblyStateCreateInf =
                pipelineDefitions[i].InputAssemblyState.HasValue
                    ? new()
                    {
                        topology = pipelineDefitions[i].InputAssemblyState!.Value.Topology,
                        primitiveRestartEnable = (uint)(pipelineDefitions[i].InputAssemblyState!.Value.PrimitiveRestartEnable ? 1 : 0)
                    }
                    : null;

            inputAssemblyStates.Add(inputAssemblyStateCreateInf);

            UnmanagedBuffer<VkPipelineShaderStageCreateInfo> stageBuffer = new(pipelineDefitions[i].Stages.Length, true);

            for (var j = 0; j < pipelineDefitions[i].Stages.Length; j++)
            {
                VkSpecializationInfo* specializationInfoPtr = null;

                if (pipelineDefitions[i].Stages[j].SpecializationInfo is not null)
                {
                    var specialziationInfoHandle = pipelineDefitions[i].Stages[j].SpecializationInfo!.Handle;
                    specializationInfoPtr = &specialziationInfoHandle;
                }

                stageBuffer[j] = new()
                {
                    // TODO: pNext
                    flags = pipelineDefitions[i].Stages[j].Flags,
                    pName = pipelineDefitions[i].Stages[j].Name.AsPointer(),
                    stage = pipelineDefitions[i].Stages[j].Stage,
                    module = pipelineDefitions[i].Stages[j].Module.Handle,
                    pSpecializationInfo = specializationInfoPtr,
                };
            }

            stages.Add(stageBuffer);

            VkPipelineViewportStateCreateInfo? viewportStateCreateInfo = pipelineDefitions[i].ViewportState is not null
                ? new()
                {
                    viewportCount = (uint) pipelineDefitions[i].ViewportState!.Viewports.Length,
                    pViewports = pipelineDefitions[i].ViewportState!.Viewports.AsPointer(),
                    scissorCount = (uint) pipelineDefitions[i].ViewportState!.Scissors.Length,
                    pScissors = pipelineDefitions[i].ViewportState!.Scissors.AsPointer(),
                }
                : null;

            viewportStates.Add(viewportStateCreateInfo);

            VkPipelineRasterizationStateCreateInfo? rasterizationStateCreateInfo = pipelineDefitions[i].RasterizationState is not null
                ? new()
                {
                    // TODO: pNext
                    depthClampEnable = (uint) (pipelineDefitions[i].RasterizationState!.Value.DepthClampEnable ? 1 : 0),
                    rasterizerDiscardEnable = (uint)(pipelineDefitions[i].RasterizationState!.Value.RasterizerDiscardEnable ? 1 : 0),
                    polygonMode = pipelineDefitions[i].RasterizationState!.Value.PolygonMode,
                    cullMode = pipelineDefitions[i].RasterizationState!.Value.CullMode,
                    frontFace = pipelineDefitions[i].RasterizationState!.Value.FrontFace,
                    depthBiasEnable = (uint)(pipelineDefitions[i].RasterizationState!.Value.DepthBiasEnable ? 1 : 0),
                    depthBiasConstantFactor = pipelineDefitions[i].RasterizationState!.Value.DepthBiasConstantFactor,
                    depthBiasClamp = pipelineDefitions[i].RasterizationState!.Value.DepthBiasClamp,
                    depthBiasSlopeFactor = pipelineDefitions[i].RasterizationState!.Value.DepthBiasSlopeFactor,
                    lineWidth = pipelineDefitions[i].RasterizationState!.Value.LineWidth
                }
                : null;

            rasterizationStates.Add(rasterizationStateCreateInfo);

            VkPipelineMultisampleStateCreateInfo? multisampleStateCreateInfo = pipelineDefitions[i].MultisampleState is not null
                ? new()
                {
                    rasterizationSamples = pipelineDefitions[i].MultisampleState!.Value.RasterizationSamples,
                    sampleShadingEnable = (uint)(pipelineDefitions[i].MultisampleState!.Value.SampleShadingEnable ? 1 : 0),
                    minSampleShading = pipelineDefitions[i].MultisampleState!.Value.MinSampleShading,
                    pSampleMask = null, // TODOs
                    alphaToCoverageEnable = (uint)(pipelineDefitions[i].MultisampleState!.Value.AlphaToCoverageEnable ? 1 : 0),
                    alphaToOneEnable = (uint)(pipelineDefitions[i].MultisampleState!.Value.AlphaToOneEnable ? 1 : 0),
                }
                : null;

            multisampleStates.Add(multisampleStateCreateInfo);

            if (pipelineDefitions[i].ColorBlendState is not null)
            {
                VkPipelineColorBlendStateCreateInfo colorBlendStateCreateInfo = new()
                {
                    logicOpEnable = (uint)(pipelineDefitions[i].ColorBlendState!.LogicOpEnable ? 1 : 0),
                    logicOp = pipelineDefitions[i].ColorBlendState!.LogicOp, 
                };

                colorBlendStateCreateInfo.blendConstants[0] = pipelineDefitions[i].ColorBlendState!.BlendConstants[0];
                colorBlendStateCreateInfo.blendConstants[1] = pipelineDefitions[i].ColorBlendState!.BlendConstants[1];
                colorBlendStateCreateInfo.blendConstants[2] = pipelineDefitions[i].ColorBlendState!.BlendConstants[2];
                colorBlendStateCreateInfo.blendConstants[3] = pipelineDefitions[i].ColorBlendState!.BlendConstants[3];

                VulkanBuffer<VkPipelineColorBlendAttachmentState> attachmentStateBuffer = new();

                for (int j = 0; j < pipelineDefitions[i].ColorBlendState!.Attachments.Length; j++)
                {
                    var attachment = pipelineDefitions[i].ColorBlendState!.Attachments[j];

                    VkPipelineColorBlendAttachmentState attachmentState = new()
                    {
                        blendEnable = (uint) (attachment.BlendEnable ? 1 : 0),
                        srcColorBlendFactor = attachment.SrcColorBlendFactor,
                        dstColorBlendFactor = attachment.DstColorBlendFactor,
                        colorBlendOp = attachment.ColorBlendOp,
                        srcAlphaBlendFactor = attachment.SrcAlphaBlendFactor,
                        dstAlphaBlendFactor = attachment.DstAlphaBlendFactor,
                        alphaBlendOp = attachment.AlphaBlendOp,
                        colorWriteMask = attachment.ColorWriteMask,
                    };

                    attachmentStateBuffer.Add(attachmentState);
                }

                colorBlendStateCreateInfo.attachmentCount = (uint) attachmentStateBuffer.Length;
                colorBlendStateCreateInfo.pAttachments = attachmentStateBuffer.AsPointer();

                colorBlendAttachmentStates.Add(attachmentStateBuffer);
                colorBlendStates.Add(colorBlendStateCreateInfo);
            }
            else
            {
                colorBlendStates.Add((VkPipelineColorBlendStateCreateInfo?) null);
            }
        }

        for (var i = 0; i < pipelineDefitions.Length; i++)
        {
            VkPipeline basePipeline = nint.Zero;

            if (pipelineDefitions[i].BasePipeline is not null)
            {
                basePipeline = pipelineDefitions[i].BasePipeline!.Handle;
            }

            vkCreateInfosPtr[i] = new()
            {
                pNext = null, // TODO
                //flags = null, // TODO
                renderPass = pipelineDefitions[i].RenderPass.Handle,
                layout = pipelineDefitions[i].PipelineLayout.Handle,
                pStages = stages.AsPointer()[i],
                stageCount = (uint)stages[i].Length,
                pDynamicState = dynamicStates.AsPointer()[i],
                pVertexInputState = vertextInputStates.AsPointer()[i],
                pInputAssemblyState = inputAssemblyStates.AsPointer()[i],
                pViewportState = viewportStates.AsPointer()[i],
                pRasterizationState = rasterizationStates.AsPointer()[i],
                pMultisampleState = multisampleStates.AsPointer()[i],
                pDepthStencilState = null, // TODO
                pColorBlendState = colorBlendStates.AsPointer()[i],
                basePipelineHandle = basePipeline,
                basePipelineIndex = pipelineDefitions[i].BasePipelineIndex,
                
                pTessellationState = null, // TODO
                subpass = pipelineDefitions[i].Subpass
            };
        }

        VkPipeline* pipelinesPtr = stackalloc VkPipeline[pipelineDefitions.Length];

        _commands.vkCreateGraphicsPipelines(_handle, pipelineCache, (uint)pipelineDefitions.Length, vkCreateInfosPtr, null, pipelinesPtr)
            .ThrowOnError();

        var pipelines = new Pipeline[pipelineDefitions.Length];

        for(var i = 0; i < pipelineDefitions.Length; i++)
        {
            pipelines[i] = new Pipeline(pipelinesPtr[i], _handle, _commands);
        }

        return pipelines;
    }

    public Framebuffer CreateFramebuffer(RenderPass renderPass, Span<ImageView> imageViews, uint width, uint height, uint layers)
    {
        VkImageView* imageViewsPtr = stackalloc VkImageView[imageViews.Length];

        for(var i = 0; i < imageViews.Length; i++)
        {
            imageViewsPtr[i] = imageViews[i].Handle;
        }

        VkFramebufferCreateInfo createInfo = new()
        {
            renderPass = renderPass.Handle,
            attachmentCount = (uint) imageViews.Length,
            pAttachments = imageViewsPtr,
            layers = layers,
            width = width,
            height = height,
        };

        VkFramebuffer vkFramebuffer;

        _commands.vkCreateFramebuffer(Handle, &createInfo, null, &vkFramebuffer).ThrowOnError();

        return new Framebuffer(vkFramebuffer, _handle, _commands);
    }

    public CommandPool CreateCommandPool(VkCommandPoolCreateFlags flags, uint queueFamilyIndex)
    {
        VkCommandPoolCreateInfo commandPoolCreateInfo = new()
        {
            flags = flags,
            queueFamilyIndex = queueFamilyIndex
        };

        VkCommandPool vkCommandPool;

        _commands.vkCreateCommandPool(_handle, &commandPoolCreateInfo, null, &vkCommandPool).ThrowOnError();

        return new CommandPool(vkCommandPool, _handle, _commands);
    }

    public VulkanSemaphore CreateSemaphore()
    {
        VkSemaphoreCreateInfo createInfo = new();

        VkSemaphore vkSemaphore;

        _commands.vkCreateSemaphore(_handle, &createInfo, null, &vkSemaphore);

        return new VulkanSemaphore(vkSemaphore, _handle, _commands);
    }

    public VulkanFence CreateFence(VkFenceCreateFlags flags = 0) // TODO: add None
    {
        VkFenceCreateInfo createInfo = new()
        {
            flags = flags
        };

        VkFence vkFence;

        _commands.vkCreateFence(_handle, &createInfo, null, &vkFence);

        return new VulkanFence(vkFence, _handle, _commands);
    }

    public void WaitForFence(VulkanFence fence, bool waitAll, uint timeout = uint.MaxValue)
    {
        VkFence* fencesPtr = stackalloc VkFence[1];

        fencesPtr[0] = fence.Handle;

        _commands.vkWaitForFences(_handle, 1, fencesPtr, (uint)(waitAll ? 1 : 0), timeout).ThrowOnError();
    }

    public void WaitForFences(Span<VulkanFence> fences, bool waitAll, uint timeout = uint.MaxValue)
    {
        VkFence* fencesPtr = stackalloc VkFence[fences.Length];

        for (int i = 0; i < fences.Length; i++)
        {
            fencesPtr[i] = fences[i].Handle;
        }

        _commands.vkWaitForFences(_handle, (uint)fences.Length, fencesPtr, (uint)(waitAll ? 1 : 0), timeout).ThrowOnError();
    }

    public void ResetFence(VulkanFence fence)
    {
        VkFence* fencesPtr = stackalloc VkFence[1];

        fencesPtr[0] = fence.Handle;

        _commands.vkResetFences(_handle, 1, fencesPtr).ThrowOnError();
    }

    public void ResetFences(Span<VulkanFence> fences)
    {
        VkFence* fencesPtr = stackalloc VkFence[fences.Length];

        for (int i = 0; i < fences.Length; i++)
        {
            fencesPtr[i] = fences[i].Handle;
        }

        _commands.vkResetFences(_handle, (uint)fences.Length, fencesPtr).ThrowOnError();
    }

    public void WaitIdle()
    {
        _commands.vkDeviceWaitIdle(_handle).ThrowOnError();
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
