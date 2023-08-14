using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkQcomTilePropertiesExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkFramebuffer, uint*, VkTilePropertiesQCOM*, VkResult> _vkGetFramebufferTilePropertiesQCOM;
    private delegate* unmanaged[Cdecl]<VkDevice, VkRenderingInfo*, VkTilePropertiesQCOM*, VkResult> _vkGetDynamicRenderingTilePropertiesQCOM;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetFramebufferTilePropertiesQCOM(VkDevice device, VkFramebuffer framebuffer, uint* pPropertiesCount, VkTilePropertiesQCOM* pProperties)
    {
        return _vkGetFramebufferTilePropertiesQCOM(device, framebuffer, pPropertiesCount, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetDynamicRenderingTilePropertiesQCOM(VkDevice device, VkRenderingInfo* pRenderingInfo, VkTilePropertiesQCOM* pProperties)
    {
        return _vkGetDynamicRenderingTilePropertiesQCOM(device, pRenderingInfo, pProperties);
    }
}