﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassDescriptionDepthStencilResolve
{
    public VkStructureType sType;
    public void* pNext;
    public VkResolveModeFlags depthResolveMode;
    public VkResolveModeFlags stencilResolveMode;
    public VkAttachmentReference2* pDepthStencilResolveAttachment;

    public VkSubpassDescriptionDepthStencilResolve()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION_DEPTH_STENCIL_RESOLVE;
    }
}