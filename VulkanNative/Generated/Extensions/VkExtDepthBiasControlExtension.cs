using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtDepthBiasControlExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDepthBiasInfoEXT*, void> _vkCmdSetDepthBias2EXT;

    public VkExtDepthBiasControlExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCmdSetDepthBias2EXT = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkDepthBiasInfoEXT*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetDepthBias2EXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetDepthBias2EXT(VkCommandBuffer commandBuffer, VkDepthBiasInfoEXT* pDepthBiasInfo)
    {
        _vkCmdSetDepthBias2EXT(commandBuffer, pDepthBiasInfo);
    }
}