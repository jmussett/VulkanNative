﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageCompressionControlFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 imageCompressionControl;
}