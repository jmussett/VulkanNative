﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceBorderColorSwizzleFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 borderColorSwizzle;
    public VkBool32 borderColorSwizzleFromImage;

    public VkPhysicalDeviceBorderColorSwizzleFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_BORDER_COLOR_SWIZZLE_FEATURES_EXT;
    }
}