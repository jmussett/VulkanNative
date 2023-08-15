using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrVideoDecodeQueueExtension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoDecodeInfoKHR*, void> _vkCmdDecodeVideoKHR;

    public VkKhrVideoDecodeQueueExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkCmdDecodeVideoKHR = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkVideoDecodeInfoKHR*, void>)loader.GetDeviceProcAddr(device, "vkCmdDecodeVideoKHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdDecodeVideoKHR(VkCommandBuffer commandBuffer, VkVideoDecodeInfoKHR* pDecodeInfo)
    {
        _vkCmdDecodeVideoKHR(commandBuffer, pDecodeInfo);
    }
}