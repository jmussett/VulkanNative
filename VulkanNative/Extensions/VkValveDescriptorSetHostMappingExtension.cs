﻿using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkValveDescriptorSetHostMappingExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetBindingReferenceVALVE*, VkDescriptorSetLayoutHostMappingInfoVALVE*, void> _vkGetDescriptorSetLayoutHostMappingInfoVALVE;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSet, void**, void> _vkGetDescriptorSetHostMappingVALVE;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDescriptorSetLayoutHostMappingInfoVALVE(VkDevice device, VkDescriptorSetBindingReferenceVALVE* pBindingReference, VkDescriptorSetLayoutHostMappingInfoVALVE* pHostMapping)
    {
        _vkGetDescriptorSetLayoutHostMappingInfoVALVE(device, pBindingReference, pHostMapping);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDescriptorSetHostMappingVALVE(VkDevice device, VkDescriptorSet descriptorSet, void** ppData)
    {
        _vkGetDescriptorSetHostMappingVALVE(device, descriptorSet, ppData);
    }
}