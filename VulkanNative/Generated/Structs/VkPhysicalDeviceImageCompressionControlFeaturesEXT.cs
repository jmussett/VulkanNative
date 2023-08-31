﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageCompressionControlFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 imageCompressionControl;

    public VkPhysicalDeviceImageCompressionControlFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_COMPRESSION_CONTROL_FEATURES_EXT;
    }
}