using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkAndroidExternalMemoryAndroidHardwareBufferExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, AHardwareBuffer*, VkAndroidHardwareBufferPropertiesANDROID*, VkResult> _vkGetAndroidHardwareBufferPropertiesANDROID;
    private delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetAndroidHardwareBufferInfoANDROID*, AHardwareBuffer**, VkResult> _vkGetMemoryAndroidHardwareBufferANDROID;

    public VkAndroidExternalMemoryAndroidHardwareBufferExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkGetAndroidHardwareBufferPropertiesANDROID = (delegate* unmanaged[Cdecl]<VkDevice, AHardwareBuffer*, VkAndroidHardwareBufferPropertiesANDROID*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetAndroidHardwareBufferPropertiesANDROID");
        _vkGetMemoryAndroidHardwareBufferANDROID = (delegate* unmanaged[Cdecl]<VkDevice, VkMemoryGetAndroidHardwareBufferInfoANDROID*, AHardwareBuffer**, VkResult>)loader.GetDeviceProcAddr(device, "vkGetMemoryAndroidHardwareBufferANDROID");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetAndroidHardwareBufferPropertiesANDROID(VkDevice device, AHardwareBuffer* buffer, VkAndroidHardwareBufferPropertiesANDROID* pProperties)
    {
        return _vkGetAndroidHardwareBufferPropertiesANDROID(device, buffer, pProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetMemoryAndroidHardwareBufferANDROID(VkDevice device, VkMemoryGetAndroidHardwareBufferInfoANDROID* pInfo, AHardwareBuffer** pBuffer)
    {
        return _vkGetMemoryAndroidHardwareBufferANDROID(device, pInfo, pBuffer);
    }
}