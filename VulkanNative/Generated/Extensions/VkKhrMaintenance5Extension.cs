using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrMaintenance5Extension
{
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkDeviceSize, VkIndexType, void> _vkCmdBindIndexBuffer2KHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkRenderingAreaInfoKHR*, VkExtent2D*, void> _vkGetRenderingAreaGranularityKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageSubresourceInfoKHR*, VkSubresourceLayout2KHR*, void> _vkGetDeviceImageSubresourceLayoutKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageSubresource2KHR*, VkSubresourceLayout2KHR*, void> _vkGetImageSubresourceLayout2KHR;

    public VkKhrMaintenance5Extension(VkDevice device, IFunctionLoader loader)
    {
        _vkCmdBindIndexBuffer2KHR = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkBuffer, VkDeviceSize, VkDeviceSize, VkIndexType, void>)loader.GetDeviceProcAddr(device, "vkCmdBindIndexBuffer2KHR");
        _vkGetRenderingAreaGranularityKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkRenderingAreaInfoKHR*, VkExtent2D*, void>)loader.GetDeviceProcAddr(device, "vkGetRenderingAreaGranularityKHR");
        _vkGetDeviceImageSubresourceLayoutKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceImageSubresourceInfoKHR*, VkSubresourceLayout2KHR*, void>)loader.GetDeviceProcAddr(device, "vkGetDeviceImageSubresourceLayoutKHR");
        _vkGetImageSubresourceLayout2KHR = (delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageSubresource2KHR*, VkSubresourceLayout2KHR*, void>)loader.GetDeviceProcAddr(device, "vkGetImageSubresourceLayout2KHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdBindIndexBuffer2KHR(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkDeviceSize size, VkIndexType indexType)
    {
        _vkCmdBindIndexBuffer2KHR(commandBuffer, buffer, offset, size, indexType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkGetRenderingAreaGranularityKHR(VkDevice device, VkRenderingAreaInfoKHR* pRenderingAreaInfo, VkExtent2D* pGranularity)
    {
        _vkGetRenderingAreaGranularityKHR(device, pRenderingAreaInfo, pGranularity);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkGetDeviceImageSubresourceLayoutKHR(VkDevice device, VkDeviceImageSubresourceInfoKHR* pInfo, VkSubresourceLayout2KHR* pLayout)
    {
        _vkGetDeviceImageSubresourceLayoutKHR(device, pInfo, pLayout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkGetImageSubresourceLayout2KHR(VkDevice device, VkImage image, VkImageSubresource2KHR* pSubresource, VkSubresourceLayout2KHR* pLayout)
    {
        _vkGetImageSubresourceLayout2KHR(device, image, pSubresource, pLayout);
    }
}