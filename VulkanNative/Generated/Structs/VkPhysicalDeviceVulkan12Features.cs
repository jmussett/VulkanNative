﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceVulkan12Features
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 SamplerMirrorClampToEdge;
    public VkBool32 DrawIndirectCount;
    public VkBool32 StorageBuffer8BitAccess;
    public VkBool32 UniformAndStorageBuffer8BitAccess;
    public VkBool32 StoragePushConstant8;
    public VkBool32 ShaderBufferInt64Atomics;
    public VkBool32 ShaderSharedInt64Atomics;
    public VkBool32 ShaderFloat16;
    public VkBool32 ShaderInt8;
    public VkBool32 DescriptorIndexing;
    public VkBool32 ShaderInputAttachmentArrayDynamicIndexing;
    public VkBool32 ShaderUniformTexelBufferArrayDynamicIndexing;
    public VkBool32 ShaderStorageTexelBufferArrayDynamicIndexing;
    public VkBool32 ShaderUniformBufferArrayNonUniformIndexing;
    public VkBool32 ShaderSampledImageArrayNonUniformIndexing;
    public VkBool32 ShaderStorageBufferArrayNonUniformIndexing;
    public VkBool32 ShaderStorageImageArrayNonUniformIndexing;
    public VkBool32 ShaderInputAttachmentArrayNonUniformIndexing;
    public VkBool32 ShaderUniformTexelBufferArrayNonUniformIndexing;
    public VkBool32 ShaderStorageTexelBufferArrayNonUniformIndexing;
    public VkBool32 DescriptorBindingUniformBufferUpdateAfterBind;
    public VkBool32 DescriptorBindingSampledImageUpdateAfterBind;
    public VkBool32 DescriptorBindingStorageImageUpdateAfterBind;
    public VkBool32 DescriptorBindingStorageBufferUpdateAfterBind;
    public VkBool32 DescriptorBindingUniformTexelBufferUpdateAfterBind;
    public VkBool32 DescriptorBindingStorageTexelBufferUpdateAfterBind;
    public VkBool32 DescriptorBindingUpdateUnusedWhilePending;
    public VkBool32 DescriptorBindingPartiallyBound;
    public VkBool32 DescriptorBindingVariableDescriptorCount;
    public VkBool32 RuntimeDescriptorArray;
    public VkBool32 SamplerFilterMinmax;
    public VkBool32 ScalarBlockLayout;
    public VkBool32 ImagelessFramebuffer;
    public VkBool32 UniformBufferStandardLayout;
    public VkBool32 ShaderSubgroupExtendedTypes;
    public VkBool32 SeparateDepthStencilLayouts;
    public VkBool32 HostQueryReset;
    public VkBool32 TimelineSemaphore;
    public VkBool32 BufferDeviceAddress;
    public VkBool32 BufferDeviceAddressCaptureReplay;
    public VkBool32 BufferDeviceAddressMultiDevice;
    public VkBool32 VulkanMemoryModel;
    public VkBool32 VulkanMemoryModelDeviceScope;
    public VkBool32 VulkanMemoryModelAvailabilityVisibilityChains;
    public VkBool32 ShaderOutputViewportIndex;
    public VkBool32 ShaderOutputLayer;
    public VkBool32 SubgroupBroadcastDynamicId;
}