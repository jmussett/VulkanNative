﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageSwapchainCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkSwapchainKHR swapchain;

    public VkImageSwapchainCreateInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_SWAPCHAIN_CREATE_INFO_KHR;
    }
}