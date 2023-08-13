﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVulkan13Properties
{
    public VkStructureType SType;
    public void* PNext;
    public uint MinSubgroupSize;
    public uint MaxSubgroupSize;
    public uint MaxComputeWorkgroupSubgroups;
    public VkShaderStageFlags RequiredSubgroupSizeStages;
    public uint MaxInlineUniformBlockSize;
    public uint MaxPerStageDescriptorInlineUniformBlocks;
    public uint MaxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
    public uint MaxDescriptorSetInlineUniformBlocks;
    public uint MaxDescriptorSetUpdateAfterBindInlineUniformBlocks;
    public uint MaxInlineUniformTotalSize;
    public VkBool32 IntegerDotProduct8BitUnsignedAccelerated;
    public VkBool32 IntegerDotProduct8BitSignedAccelerated;
    public VkBool32 IntegerDotProduct8BitMixedSignednessAccelerated;
    public VkBool32 IntegerDotProduct4x8BitPackedUnsignedAccelerated;
    public VkBool32 IntegerDotProduct4x8BitPackedSignedAccelerated;
    public VkBool32 IntegerDotProduct4x8BitPackedMixedSignednessAccelerated;
    public VkBool32 IntegerDotProduct16BitUnsignedAccelerated;
    public VkBool32 IntegerDotProduct16BitSignedAccelerated;
    public VkBool32 IntegerDotProduct16BitMixedSignednessAccelerated;
    public VkBool32 IntegerDotProduct32BitUnsignedAccelerated;
    public VkBool32 IntegerDotProduct32BitSignedAccelerated;
    public VkBool32 IntegerDotProduct32BitMixedSignednessAccelerated;
    public VkBool32 IntegerDotProduct64BitUnsignedAccelerated;
    public VkBool32 IntegerDotProduct64BitSignedAccelerated;
    public VkBool32 IntegerDotProduct64BitMixedSignednessAccelerated;
    public VkBool32 IntegerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
    public VkBool32 IntegerDotProductAccumulatingSaturating8BitSignedAccelerated;
    public VkBool32 IntegerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
    public VkBool32 IntegerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
    public VkBool32 IntegerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
    public VkBool32 IntegerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
    public VkBool32 IntegerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
    public VkBool32 IntegerDotProductAccumulatingSaturating16BitSignedAccelerated;
    public VkBool32 IntegerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
    public VkBool32 IntegerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
    public VkBool32 IntegerDotProductAccumulatingSaturating32BitSignedAccelerated;
    public VkBool32 IntegerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
    public VkBool32 IntegerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
    public VkBool32 IntegerDotProductAccumulatingSaturating64BitSignedAccelerated;
    public VkBool32 IntegerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
    public VkDeviceSize StorageTexelBufferOffsetAlignmentBytes;
    public VkBool32 StorageTexelBufferOffsetSingleTexelAlignment;
    public VkDeviceSize UniformTexelBufferOffsetAlignmentBytes;
    public VkBool32 UniformTexelBufferOffsetSingleTexelAlignment;
    public VkDeviceSize MaxBufferSize;
}