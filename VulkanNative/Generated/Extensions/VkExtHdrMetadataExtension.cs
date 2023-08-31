using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtHdrMetadataExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, uint, VkSwapchainKHR*, VkHdrMetadataEXT*, void> _vkSetHdrMetadataEXT;

    public VkExtHdrMetadataExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkSetHdrMetadataEXT = (delegate* unmanaged[Cdecl]<VkDevice, uint, VkSwapchainKHR*, VkHdrMetadataEXT*, void>)loader.GetDeviceProcAddr(device, "vkSetHdrMetadataEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkSetHdrMetadataEXT(VkDevice device, uint swapchainCount, VkSwapchainKHR* pSwapchains, VkHdrMetadataEXT* pMetadata)
    {
        _vkSetHdrMetadataEXT(device, swapchainCount, pSwapchains, pMetadata);
    }
}