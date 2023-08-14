namespace VulkanNative;

public unsafe class VkNvShadingRateImageExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImageView, VkImageLayout, void> vkCmdBindShadingRateImageNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkShadingRatePaletteNV*, void> vkCmdSetViewportShadingRatePaletteNV;
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCoarseSampleOrderTypeNV, uint, VkCoarseSampleOrderCustomNV*, void> vkCmdSetCoarseSampleOrderNV;
}