using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkHuaweiInvocationMaskExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkImageView, VkImageLayout, void> _vkCmdBindInvocationMaskHUAWEI;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdBindInvocationMaskHUAWEI(VkCommandBuffer commandBuffer, VkImageView imageView, VkImageLayout imageLayout)
    {
        _vkCmdBindInvocationMaskHUAWEI(commandBuffer, imageView, imageLayout);
    }
}