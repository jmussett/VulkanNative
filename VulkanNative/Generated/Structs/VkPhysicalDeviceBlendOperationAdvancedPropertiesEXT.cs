﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint advancedBlendMaxColorAttachments;
    public VkBool32 advancedBlendIndependentBlend;
    public VkBool32 advancedBlendNonPremultipliedSrcColor;
    public VkBool32 advancedBlendNonPremultipliedDstColor;
    public VkBool32 advancedBlendCorrelatedOverlap;
    public VkBool32 advancedBlendAllOperations;

    public VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BLEND_OPERATION_ADVANCED_PROPERTIES_EXT;
    }
}