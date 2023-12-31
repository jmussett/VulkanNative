﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetLayoutCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkDescriptorSetLayoutCreateFlags flags;
    public uint bindingCount;
    public VkDescriptorSetLayoutBinding* pBindings;

    public VkDescriptorSetLayoutCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_CREATE_INFO;
    }
}