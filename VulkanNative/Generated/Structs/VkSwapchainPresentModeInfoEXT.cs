﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSwapchainPresentModeInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint swapchainCount;
    public VkPresentModeKHR* pPresentModes;

    public VkSwapchainPresentModeInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SWAPCHAIN_PRESENT_MODE_INFO_EXT;
    }
}