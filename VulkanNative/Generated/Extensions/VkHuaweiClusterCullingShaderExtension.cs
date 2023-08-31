using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkHuaweiClusterCullingShaderExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, uint, void> _vkCmdDrawClusterHUAWEI;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, void> _vkCmdDrawClusterIndirectHUAWEI;

    public VkHuaweiClusterCullingShaderExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCmdDrawClusterHUAWEI = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, uint, void>)loader.GetDeviceProcAddr(device, "vkCmdDrawClusterHUAWEI");
        _vkCmdDrawClusterIndirectHUAWEI = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, void>)loader.GetDeviceProcAddr(device, "vkCmdDrawClusterIndirectHUAWEI");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdDrawClusterHUAWEI(VkCommandBuffer commandBuffer, uint groupCountX, uint groupCountY, uint groupCountZ)
    {
        _vkCmdDrawClusterHUAWEI(commandBuffer, groupCountX, groupCountY, groupCountZ);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdDrawClusterIndirectHUAWEI(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset)
    {
        _vkCmdDrawClusterIndirectHUAWEI(commandBuffer, buffer, offset);
    }
}