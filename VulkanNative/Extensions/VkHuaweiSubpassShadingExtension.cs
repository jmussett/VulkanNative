using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkHuaweiSubpassShadingExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkRenderPass, VkExtent2D*, VkResult> _vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, void> _vkCmdSubpassShadingHUAWEI;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(VkDevice device, VkRenderPass renderpass, VkExtent2D* pMaxWorkgroupSize)
    {
        return _vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI(device, renderpass, pMaxWorkgroupSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdSubpassShadingHUAWEI(VkCommandBuffer commandBuffer)
    {
        _vkCmdSubpassShadingHUAWEI(commandBuffer);
    }
}