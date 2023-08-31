using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvFragmentShadingRateEnumsExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkFragmentShadingRateNV, VkFragmentShadingRateCombinerOpKHR*, void> _vkCmdSetFragmentShadingRateEnumNV;

    public VkNvFragmentShadingRateEnumsExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCmdSetFragmentShadingRateEnumNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkFragmentShadingRateNV, VkFragmentShadingRateCombinerOpKHR*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetFragmentShadingRateEnumNV");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSetFragmentShadingRateEnumNV(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, VkFragmentShadingRateCombinerOpKHR* combinerOps)
    {
        _vkCmdSetFragmentShadingRateEnumNV(commandBuffer, shadingRate, combinerOps);
    }
}