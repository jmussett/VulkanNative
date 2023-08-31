using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkHuaweiSubpassShadingExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkRenderPass, VkExtent2D*, VkResult> _vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, void> _vkCmdSubpassShadingHUAWEI;

    public VkHuaweiSubpassShadingExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI = (delegate* unmanaged[Cdecl]<VkDevice, VkRenderPass, VkExtent2D*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI");
        _vkCmdSubpassShadingHUAWEI = (delegate* unmanaged[Cdecl]<VkCommandBuffer, void>)loader.GetDeviceProcAddr(device, "vkCmdSubpassShadingHUAWEI");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(VkDevice device, VkRenderPass renderpass, VkExtent2D* pMaxWorkgroupSize)
    {
        return _vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(device, renderpass, pMaxWorkgroupSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkCmdSubpassShadingHUAWEI(VkCommandBuffer commandBuffer)
    {
        _vkCmdSubpassShadingHUAWEI(commandBuffer);
    }
}