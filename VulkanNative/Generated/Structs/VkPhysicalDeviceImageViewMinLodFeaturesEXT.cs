﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageViewMinLodFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 minLod;

    public VkPhysicalDeviceImageViewMinLodFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_VIEW_MIN_LOD_FEATURES_EXT;
    }
}