using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvFragmentShadingRateEnumsExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkFragmentShadingRateNV, VkFragmentShadingRateCombinerOpKHR*, void> _vkCmdSetFragmentShadingRateEnumNV;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetFragmentShadingRateEnumNV(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, VkFragmentShadingRateCombinerOpKHR* combinerOps)
    {
        _vkCmdSetFragmentShadingRateEnumNV(commandBuffer, shadingRate, combinerOps);
    }
}