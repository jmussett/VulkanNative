using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtDescriptorBufferExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayout, VkDeviceSize*, void> _vkGetDescriptorSetLayoutSizeEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayout, uint, VkDeviceSize*, void> _vkGetDescriptorSetLayoutBindingOffsetEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorGetInfoEXT*, nint, void*, void> _vkGetDescriptorEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkDescriptorBufferBindingInfoEXT*, void> _vkCmdBindDescriptorBuffersEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, uint*, VkDeviceSize*, void> _vkCmdSetDescriptorBufferOffsetsEXT;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, void> _vkCmdBindDescriptorBufferEmbeddedSamplersEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkBufferCaptureDescriptorDataInfoEXT*, void*, VkResult> _vkGetBufferOpaqueCaptureDescriptorDataEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkImageCaptureDescriptorDataInfoEXT*, void*, VkResult> _vkGetImageOpaqueCaptureDescriptorDataEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkImageViewCaptureDescriptorDataInfoEXT*, void*, VkResult> _vkGetImageViewOpaqueCaptureDescriptorDataEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSamplerCaptureDescriptorDataInfoEXT*, void*, VkResult> _vkGetSamplerOpaqueCaptureDescriptorDataEXT;
    private delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureCaptureDescriptorDataInfoEXT*, void*, VkResult> _vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT;

    public VkExtDescriptorBufferExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkGetDescriptorSetLayoutSizeEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayout, VkDeviceSize*, void>)loader.GetDeviceProcAddr(device, "vkGetDescriptorSetLayoutSizeEXT");
        _vkGetDescriptorSetLayoutBindingOffsetEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorSetLayout, uint, VkDeviceSize*, void>)loader.GetDeviceProcAddr(device, "vkGetDescriptorSetLayoutBindingOffsetEXT");
        _vkGetDescriptorEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkDescriptorGetInfoEXT*, nint, void*, void>)loader.GetDeviceProcAddr(device, "vkGetDescriptorEXT");
        _vkCmdBindDescriptorBuffersEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, VkDescriptorBufferBindingInfoEXT*, void>)loader.GetDeviceProcAddr(device, "vkCmdBindDescriptorBuffersEXT");
        _vkCmdSetDescriptorBufferOffsetsEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, uint*, VkDeviceSize*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetDescriptorBufferOffsetsEXT");
        _vkCmdBindDescriptorBufferEmbeddedSamplersEXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdBindDescriptorBufferEmbeddedSamplersEXT");
        _vkGetBufferOpaqueCaptureDescriptorDataEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkBufferCaptureDescriptorDataInfoEXT*, void*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetBufferOpaqueCaptureDescriptorDataEXT");
        _vkGetImageOpaqueCaptureDescriptorDataEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkImageCaptureDescriptorDataInfoEXT*, void*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetImageOpaqueCaptureDescriptorDataEXT");
        _vkGetImageViewOpaqueCaptureDescriptorDataEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkImageViewCaptureDescriptorDataInfoEXT*, void*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetImageViewOpaqueCaptureDescriptorDataEXT");
        _vkGetSamplerOpaqueCaptureDescriptorDataEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkSamplerCaptureDescriptorDataInfoEXT*, void*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetSamplerOpaqueCaptureDescriptorDataEXT");
        _vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkAccelerationStructureCaptureDescriptorDataInfoEXT*, void*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDescriptorSetLayoutSizeEXT(VkDevice device, VkDescriptorSetLayout layout, VkDeviceSize* pLayoutSizeInBytes)
    {
        _vkGetDescriptorSetLayoutSizeEXT(device, layout, pLayoutSizeInBytes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDescriptorSetLayoutBindingOffsetEXT(VkDevice device, VkDescriptorSetLayout layout, uint binding, VkDeviceSize* pOffset)
    {
        _vkGetDescriptorSetLayoutBindingOffsetEXT(device, layout, binding, pOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetDescriptorEXT(VkDevice device, VkDescriptorGetInfoEXT* pDescriptorInfo, nint dataSize, void* pDescriptor)
    {
        _vkGetDescriptorEXT(device, pDescriptorInfo, dataSize, pDescriptor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBindDescriptorBuffersEXT(VkCommandBuffer commandBuffer, uint bufferCount, VkDescriptorBufferBindingInfoEXT* pBindingInfos)
    {
        _vkCmdBindDescriptorBuffersEXT(commandBuffer, bufferCount, pBindingInfos);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDescriptorBufferOffsetsEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint firstSet, uint setCount, uint* pBufferIndices, VkDeviceSize* pOffsets)
    {
        _vkCmdSetDescriptorBufferOffsetsEXT(commandBuffer, pipelineBindPoint, layout, firstSet, setCount, pBufferIndices, pOffsets);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBindDescriptorBufferEmbeddedSamplersEXT(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint set)
    {
        _vkCmdBindDescriptorBufferEmbeddedSamplersEXT(commandBuffer, pipelineBindPoint, layout, set);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetBufferOpaqueCaptureDescriptorDataEXT(VkDevice device, VkBufferCaptureDescriptorDataInfoEXT* pInfo, void* pData)
    {
        return _vkGetBufferOpaqueCaptureDescriptorDataEXT(device, pInfo, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetImageOpaqueCaptureDescriptorDataEXT(VkDevice device, VkImageCaptureDescriptorDataInfoEXT* pInfo, void* pData)
    {
        return _vkGetImageOpaqueCaptureDescriptorDataEXT(device, pInfo, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetImageViewOpaqueCaptureDescriptorDataEXT(VkDevice device, VkImageViewCaptureDescriptorDataInfoEXT* pInfo, void* pData)
    {
        return _vkGetImageViewOpaqueCaptureDescriptorDataEXT(device, pInfo, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetSamplerOpaqueCaptureDescriptorDataEXT(VkDevice device, VkSamplerCaptureDescriptorDataInfoEXT* pInfo, void* pData)
    {
        return _vkGetSamplerOpaqueCaptureDescriptorDataEXT(device, pInfo, pData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT(VkDevice device, VkAccelerationStructureCaptureDescriptorDataInfoEXT* pInfo, void* pData)
    {
        return _vkGetAccelerationStructureOpaqueCaptureDescriptorDataEXT(device, pInfo, pData);
    }
}