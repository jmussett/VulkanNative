using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtSwapchainMaintenance1Extension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkReleaseSwapchainImagesInfoEXT*, VkResult> _vkReleaseSwapchainImagesEXT;

    public VkExtSwapchainMaintenance1Extension(VkDevice device, IFunctionLoader loader)
    {
        _vkReleaseSwapchainImagesEXT = (delegate* unmanaged[Cdecl]<VkDevice, VkReleaseSwapchainImagesInfoEXT*, VkResult>)loader.GetDeviceProcAddr(device, "vkReleaseSwapchainImagesEXT");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkReleaseSwapchainImagesEXT(VkDevice device, VkReleaseSwapchainImagesInfoEXT* pReleaseInfo)
    {
        return _vkReleaseSwapchainImagesEXT(device, pReleaseInfo);
    }
}