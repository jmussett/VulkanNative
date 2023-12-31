﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderTileImageFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderTileImageColorReadAccess;
    public VkBool32 shaderTileImageDepthReadAccess;
    public VkBool32 shaderTileImageStencilReadAccess;

    public VkPhysicalDeviceShaderTileImageFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_TILE_IMAGE_FEATURES_EXT;
    }
}