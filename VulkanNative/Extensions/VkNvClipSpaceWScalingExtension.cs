namespace VulkanNative;

public unsafe class VkNvClipSpaceWScalingExtension
{
    public delegate* unmanaged[Cdecl]<VkCommandBuffer, uint, uint, VkViewportWScalingNV*, void> vkCmdSetViewportWScalingNV;
}