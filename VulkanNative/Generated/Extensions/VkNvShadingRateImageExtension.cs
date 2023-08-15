using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvShadingRateImageExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImageView, VkImageLayout, void> _vkCmdBindShadingRateImageNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkShadingRatePaletteNV*, void> _vkCmdSetViewportShadingRatePaletteNV;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCoarseSampleOrderTypeNV, uint, VkCoarseSampleOrderCustomNV*, void> _vkCmdSetCoarseSampleOrderNV;

    public VkNvShadingRateImageExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkCmdBindShadingRateImageNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImageView, VkImageLayout, void>)loader.GetDeviceProcAddr(device, "vkCmdBindShadingRateImageNV");
        _vkCmdSetViewportShadingRatePaletteNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkShadingRatePaletteNV*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetViewportShadingRatePaletteNV");
        _vkCmdSetCoarseSampleOrderNV = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCoarseSampleOrderTypeNV, uint, VkCoarseSampleOrderCustomNV*, void>)loader.GetDeviceProcAddr(device, "vkCmdSetCoarseSampleOrderNV");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBindShadingRateImageNV(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout)
    {
        _vkCmdBindShadingRateImageNV(commandBuffer, imageView, imageLayout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetViewportShadingRatePaletteNV(VkCommandBuffer commandBuffer, uint firstViewport, uint viewportCount, VkShadingRatePaletteNV* pShadingRatePalettes)
    {
        _vkCmdSetViewportShadingRatePaletteNV(commandBuffer, firstViewport, viewportCount, pShadingRatePalettes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSetCoarseSampleOrderNV(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders)
    {
        _vkCmdSetCoarseSampleOrderNV(commandBuffer, sampleOrderType, customSampleOrderCount, pCustomSampleOrders);
    }
}