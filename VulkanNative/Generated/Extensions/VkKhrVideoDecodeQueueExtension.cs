using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrVideoDecodeQueueExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoDecodeInfoKHR*, void> _vkCmdDecodeVideoKHR;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDecodeVideoKHR(VkCommandBuffer commandBuffer, VkVideoDecodeInfoKHR* pDecodeInfo)
    {
        _vkCmdDecodeVideoKHR(commandBuffer, pDecodeInfo);
    }
}