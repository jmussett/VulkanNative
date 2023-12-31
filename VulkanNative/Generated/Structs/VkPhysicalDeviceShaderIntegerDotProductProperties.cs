﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderIntegerDotProductProperties
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 integerDotProduct8BitUnsignedAccelerated;
    public VkBool32 integerDotProduct8BitSignedAccelerated;
    public VkBool32 integerDotProduct8BitMixedSignednessAccelerated;
    public VkBool32 integerDotProduct4x8BitPackedUnsignedAccelerated;
    public VkBool32 integerDotProduct4x8BitPackedSignedAccelerated;
    public VkBool32 integerDotProduct4x8BitPackedMixedSignednessAccelerated;
    public VkBool32 integerDotProduct16BitUnsignedAccelerated;
    public VkBool32 integerDotProduct16BitSignedAccelerated;
    public VkBool32 integerDotProduct16BitMixedSignednessAccelerated;
    public VkBool32 integerDotProduct32BitUnsignedAccelerated;
    public VkBool32 integerDotProduct32BitSignedAccelerated;
    public VkBool32 integerDotProduct32BitMixedSignednessAccelerated;
    public VkBool32 integerDotProduct64BitUnsignedAccelerated;
    public VkBool32 integerDotProduct64BitSignedAccelerated;
    public VkBool32 integerDotProduct64BitMixedSignednessAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating8BitSignedAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating16BitSignedAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating32BitSignedAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating64BitSignedAccelerated;
    public VkBool32 integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;

    public VkPhysicalDeviceShaderIntegerDotProductProperties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_INTEGER_DOT_PRODUCT_PROPERTIES;
    }
}