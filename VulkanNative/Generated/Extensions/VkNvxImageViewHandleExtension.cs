using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvxImageViewHandleExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkImageViewHandleInfoNVX*, uint> _vkGetImageViewHandleNVX;
    private delegate* unmanaged[Cdecl]<VkDevice, VkImageView, VkImageViewAddressPropertiesNVX*, VkResult> _vkGetImageViewAddressNVX;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public uint VkGetImageViewHandleNVX(VkDevice device, VkImageViewHandleInfoNVX* pInfo)
    {
        return _vkGetImageViewHandleNVX(device, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetImageViewAddressNVX(VkDevice device, VkImageView imageView, VkImageViewAddressPropertiesNVX* pProperties)
    {
        return _vkGetImageViewAddressNVX(device, imageView, pProperties);
    }
}