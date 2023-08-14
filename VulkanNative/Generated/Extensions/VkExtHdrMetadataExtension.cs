using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtHdrMetadataExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, uint, VkSwapchainKHR*, VkHdrMetadataEXT*, void> _vkSetHdrMetadataEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, VkHdrMetadataEXT* pMetadata)
    {
        _vkSetHdrMetadataEXT(device, swapchainCount, pSwapchains, pMetadata);
    }
}