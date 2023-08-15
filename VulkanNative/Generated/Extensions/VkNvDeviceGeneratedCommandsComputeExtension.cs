using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvDeviceGeneratedCommandsComputeExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkComputePipelineCreateInfo*, VkMemoryRequirements2*, void> _vkGetPipelineIndirectMemoryRequirementsNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void> _vkCmdUpdatePipelineIndirectBufferNV;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPipelineIndirectDeviceAddressInfoNV*, VkDeviceAddress> _vkGetPipelineIndirectDeviceAddressNV;

    public VkNvDeviceGeneratedCommandsComputeExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkGetPipelineIndirectMemoryRequirementsNV = (delegate* unmanaged[Cdecl]<VkDevice, VkComputePipelineCreateInfo*, VkMemoryRequirements2*, void>)loader.GetDeviceProcAddr(device, "vkGetPipelineIndirectMemoryRequirementsNV");
        _vkCmdUpdatePipelineIndirectBufferNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void>)loader.GetDeviceProcAddr(device, "vkCmdUpdatePipelineIndirectBufferNV");
        _vkGetPipelineIndirectDeviceAddressNV = (delegate* unmanaged[Cdecl]<VkDevice, VkPipelineIndirectDeviceAddressInfoNV*, VkDeviceAddress>)loader.GetDeviceProcAddr(device, "vkGetPipelineIndirectDeviceAddressNV");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetPipelineIndirectMemoryRequirementsNV(VkDevice device, VkComputePipelineCreateInfo* pCreateInfo, VkMemoryRequirements2* pMemoryRequirements)
    {
        _vkGetPipelineIndirectMemoryRequirementsNV(device, pCreateInfo, pMemoryRequirements);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdUpdatePipelineIndirectBufferNV(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline)
    {
        _vkCmdUpdatePipelineIndirectBufferNV(commandBuffer, pipelineBindPoint, pipeline);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkDeviceAddress VkGetPipelineIndirectDeviceAddressNV(VkDevice device, VkPipelineIndirectDeviceAddressInfoNV* pInfo)
    {
        return _vkGetPipelineIndirectDeviceAddressNV(device, pInfo);
    }
}