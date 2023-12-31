﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceGroupRenderPassBeginInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint deviceMask;
    public uint deviceRenderAreaCount;
    public VkRect2D* pDeviceRenderAreas;

    public VkDeviceGroupRenderPassBeginInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_GROUP_RENDER_PASS_BEGIN_INFO;
    }
}