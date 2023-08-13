﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDescriptorIndexingProperties
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxUpdateAfterBindDescriptorsInAllPools;
    public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
    public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
    public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
    public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
    public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
    public VkBool32 robustBufferAccessUpdateAfterBind;
    public VkBool32 quadDivergentImplicitLod;
    public uint maxPerStageDescriptorUpdateAfterBindSamplers;
    public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
    public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
    public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
    public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
    public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
    public uint maxPerStageUpdateAfterBindResources;
    public uint maxDescriptorSetUpdateAfterBindSamplers;
    public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
    public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
    public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
    public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
    public uint maxDescriptorSetUpdateAfterBindSampledImages;
    public uint maxDescriptorSetUpdateAfterBindStorageImages;
    public uint maxDescriptorSetUpdateAfterBindInputAttachments;
}