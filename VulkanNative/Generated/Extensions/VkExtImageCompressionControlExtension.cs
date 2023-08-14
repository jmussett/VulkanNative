using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtImageCompressionControlExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkImage, VkImageSubresource2KHR*, VkSubresourceLayout2KHR*, void> _vkGetImageSubresourceLayout2KHR;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkGetImageSubresourceLayout2KHR(VkDevice device, VkImage image, VkImageSubresource2KHR* pSubresource, VkSubresourceLayout2KHR* pLayout)
    {
        _vkGetImageSubresourceLayout2KHR(device, image, pSubresource, pLayout);
    }
}