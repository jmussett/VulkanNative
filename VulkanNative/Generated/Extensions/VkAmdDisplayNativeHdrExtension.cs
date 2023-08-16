using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkAmdDisplayNativeHdrExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkBool32, void> _vkSetLocalDimmingAMD;

    public VkAmdDisplayNativeHdrExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkSetLocalDimmingAMD = (delegate* unmanaged[Cdecl]<VkDevice, VkSwapchainKHR, VkBool32, void>)loader.GetDeviceProcAddr(device, "vkSetLocalDimmingAMD");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkSetLocalDimmingAMD(VkDevice device, VkSwapchainKHR swapChain, VkBool32 localDimmingEnable)
    {
        _vkSetLocalDimmingAMD(device, swapChain, localDimmingEnable);
    }
}