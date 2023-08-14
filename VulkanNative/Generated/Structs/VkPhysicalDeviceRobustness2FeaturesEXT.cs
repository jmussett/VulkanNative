﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRobustness2FeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 RobustBufferAccess2;
    public VkBool32 RobustImageAccess2;
    public VkBool32 NullDescriptor;
}