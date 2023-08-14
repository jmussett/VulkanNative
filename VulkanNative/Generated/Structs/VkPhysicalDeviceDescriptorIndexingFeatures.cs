﻿using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDescriptorIndexingFeatures
{
    public VkStructureType SType;
    public void* PNext;
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
}