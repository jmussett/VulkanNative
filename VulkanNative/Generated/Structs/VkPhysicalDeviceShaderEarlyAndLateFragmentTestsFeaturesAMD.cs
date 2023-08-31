﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderEarlyAndLateFragmentTests;

    public VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_EARLY_AND_LATE_FRAGMENT_TESTS_FEATURES_AMD;
    }
}