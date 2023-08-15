using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrMaintenance1Extension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void> _vkTrimCommandPool;

    public VkKhrMaintenance1Extension(VkDevice device, IVulkanLoader loader)
    {
        _vkTrimCommandPool = (delegate* unmanaged[Cdecl]<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void>)loader.GetDeviceProcAddr(device, "vkTrimCommandPool");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkTrimCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolTrimFlags flags)
    {
        _vkTrimCommandPool(device, commandPool, flags);
    }
}