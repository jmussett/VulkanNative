using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtSwapchainMaintenance1Extension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkReleaseSwapchainImagesInfoEXT*, VkResult> _vkReleaseSwapchainImagesEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkReleaseSwapchainImagesEXT(VkDevice device, VkReleaseSwapchainImagesInfoEXT* pReleaseInfo)
    {
        return _vkReleaseSwapchainImagesEXT(device, pReleaseInfo);
    }
}