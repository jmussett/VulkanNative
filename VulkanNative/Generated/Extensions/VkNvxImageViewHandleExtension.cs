using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvxImageViewHandleExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkImageViewHandleInfoNVX*, uint> _vkGetImageViewHandleNVX;
    private delegate* unmanaged[Cdecl]<VkDevice, VkImageView, VkImageViewAddressPropertiesNVX*, VkResult> _vkGetImageViewAddressNVX;

    public VkNvxImageViewHandleExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkGetImageViewHandleNVX = (delegate* unmanaged[Cdecl]<VkDevice, VkImageViewHandleInfoNVX*, uint>)loader.GetDeviceProcAddr(device, "vkGetImageViewHandleNVX");
        _vkGetImageViewAddressNVX = (delegate* unmanaged[Cdecl]<VkDevice, VkImageView, VkImageViewAddressPropertiesNVX*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetImageViewAddressNVX");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public uint vkGetImageViewHandleNVX(VkDevice device, VkImageViewHandleInfoNVX* pInfo)
    {
        return _vkGetImageViewHandleNVX(device, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetImageViewAddressNVX(VkDevice device, VkImageView imageView, VkImageViewAddressPropertiesNVX* pProperties)
    {
        return _vkGetImageViewAddressNVX(device, imageView, pProperties);
    }
}