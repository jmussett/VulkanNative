﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDrmPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 hasPrimary;
    public VkBool32 hasRender;
    public long primaryMajor;
    public long primaryMinor;
    public long renderMajor;
    public long renderMinor;

    public VkPhysicalDeviceDrmPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DRM_PROPERTIES_EXT;
    }
}