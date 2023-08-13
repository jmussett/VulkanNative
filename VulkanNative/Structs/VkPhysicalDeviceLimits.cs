﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceLimits
{
    public uint MaxImageDimension1D;
    public uint MaxImageDimension2D;
    public uint MaxImageDimension3D;
    public uint MaxImageDimensionCube;
    public uint MaxImageArrayLayers;
    public uint MaxTexelBufferElements;
    public uint MaxUniformBufferRange;
    public uint MaxStorageBufferRange;
    public uint MaxPushConstantsSize;
    public uint MaxMemoryAllocationCount;
    public uint MaxSamplerAllocationCount;
    public VkDeviceSize BufferImageGranularity;
    public VkDeviceSize SparseAddressSpaceSize;
    public uint MaxBoundDescriptorSets;
    public uint MaxPerStageDescriptorSamplers;
    public uint MaxPerStageDescriptorUniformBuffers;
    public uint MaxPerStageDescriptorStorageBuffers;
    public uint MaxPerStageDescriptorSampledImages;
    public uint MaxPerStageDescriptorStorageImages;
    public uint MaxPerStageDescriptorInputAttachments;
    public uint MaxPerStageResources;
    public uint MaxDescriptorSetSamplers;
    public uint MaxDescriptorSetUniformBuffers;
    public uint MaxDescriptorSetUniformBuffersDynamic;
    public uint MaxDescriptorSetStorageBuffers;
    public uint MaxDescriptorSetStorageBuffersDynamic;
    public uint MaxDescriptorSetSampledImages;
    public uint MaxDescriptorSetStorageImages;
    public uint MaxDescriptorSetInputAttachments;
    public uint MaxVertexInputAttributes;
    public uint MaxVertexInputBindings;
    public uint MaxVertexInputAttributeOffset;
    public uint MaxVertexInputBindingStride;
    public uint MaxVertexOutputComponents;
    public uint MaxTessellationGenerationLevel;
    public uint MaxTessellationPatchSize;
    public uint MaxTessellationControlPerVertexInputComponents;
    public uint MaxTessellationControlPerVertexOutputComponents;
    public uint MaxTessellationControlPerPatchOutputComponents;
    public uint MaxTessellationControlTotalOutputComponents;
    public uint MaxTessellationEvaluationInputComponents;
    public uint MaxTessellationEvaluationOutputComponents;
    public uint MaxGeometryShaderInvocations;
    public uint MaxGeometryInputComponents;
    public uint MaxGeometryOutputComponents;
    public uint MaxGeometryOutputVertices;
    public uint MaxGeometryTotalOutputComponents;
    public uint MaxFragmentInputComponents;
    public uint MaxFragmentOutputAttachments;
    public uint MaxFragmentDualSrcAttachments;
    public uint MaxFragmentCombinedOutputResources;
    public uint MaxComputeSharedMemorySize;
    public fixed uint MaxComputeWorkGroupCount[3];
    public uint MaxComputeWorkGroupInvocations;
    public fixed uint MaxComputeWorkGroupSize[3];
    public uint SubPixelPrecisionBits;
    public uint SubTexelPrecisionBits;
    public uint MipmapPrecisionBits;
    public uint MaxDrawIndexedIndexValue;
    public uint MaxDrawIndirectCount;
    public float MaxSamplerLodBias;
    public float MaxSamplerAnisotropy;
    public uint MaxViewports;
    public fixed uint MaxViewportDimensions[2];
    public fixed float ViewportBoundsRange[2];
    public uint ViewportSubPixelBits;
    public nint MinMemoryMapAlignment;
    public VkDeviceSize MinTexelBufferOffsetAlignment;
    public VkDeviceSize MinUniformBufferOffsetAlignment;
    public VkDeviceSize MinStorageBufferOffsetAlignment;
    public int MinTexelOffset;
    public uint MaxTexelOffset;
    public int MinTexelGatherOffset;
    public uint MaxTexelGatherOffset;
    public float MinInterpolationOffset;
    public float MaxInterpolationOffset;
    public uint SubPixelInterpolationOffsetBits;
    public uint MaxFramebufferWidth;
    public uint MaxFramebufferHeight;
    public uint MaxFramebufferLayers;
    public VkSampleCountFlags FramebufferColorSampleCounts;
    public VkSampleCountFlags FramebufferDepthSampleCounts;
    public VkSampleCountFlags FramebufferStencilSampleCounts;
    public VkSampleCountFlags FramebufferNoAttachmentsSampleCounts;
    public uint MaxColorAttachments;
    public VkSampleCountFlags SampledImageColorSampleCounts;
    public VkSampleCountFlags SampledImageIntegerSampleCounts;
    public VkSampleCountFlags SampledImageDepthSampleCounts;
    public VkSampleCountFlags SampledImageStencilSampleCounts;
    public VkSampleCountFlags StorageImageSampleCounts;
    public uint MaxSampleMaskWords;
    public VkBool32 TimestampComputeAndGraphics;
    public float TimestampPeriod;
    public uint MaxClipDistances;
    public uint MaxCullDistances;
    public uint MaxCombinedClipAndCullDistances;
    public uint DiscreteQueuePriorities;
    public fixed float PointSizeRange[2];
    public fixed float LineWidthRange[2];
    public float PointSizeGranularity;
    public float LineWidthGranularity;
    public VkBool32 StrictLines;
    public VkBool32 StandardSampleLocations;
    public VkDeviceSize OptimalBufferCopyOffsetAlignment;
    public VkDeviceSize OptimalBufferCopyRowPitchAlignment;
    public VkDeviceSize NonCoherentAtomSize;
}