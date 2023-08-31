using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkQcomTilePropertiesExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkFramebuffer, uint*, VkTilePropertiesQCOM*, VkResult> _vkGetFramebufferTilePropertiesQCOM;
    private delegate* unmanaged[Cdecl]<VkDevice, VkRenderingInfo*, VkTilePropertiesQCOM*, VkResult> _vkGetDynamicRenderingTilePropertiesQCOM;

    public VkQcomTilePropertiesExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkGetFramebufferTilePropertiesQCOM = (delegate* unmanaged[Cdecl]<VkDevice, VkFramebuffer, uint*, VkTilePropertiesQCOM*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetFramebufferTilePropertiesQCOM");
        _vkGetDynamicRenderingTilePropertiesQCOM = (delegate* unmanaged[Cdecl]<VkDevice, VkRenderingInfo*, VkTilePropertiesQCOM*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetDynamicRenderingTilePropertiesQCOM");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetFramebufferTilePropertiesQCOM(VkDevice device, VkFramebuffer framebuffer, uint* pPropertiesCount, VkTilePropertiesQCOM* pProperties)
    {
        return _vkGetFramebufferTilePropertiesQCOM(device, framebuffer, pPropertiesCount, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetDynamicRenderingTilePropertiesQCOM(VkDevice device, VkRenderingInfo* pRenderingInfo, VkTilePropertiesQCOM* pProperties)
    {
        return _vkGetDynamicRenderingTilePropertiesQCOM(device, pRenderingInfo, pProperties);
    }
}