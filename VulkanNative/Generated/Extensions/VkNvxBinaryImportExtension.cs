using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkNvxBinaryImportExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkCuModuleCreateInfoNVX*, VkAllocationCallbacks*, VkCuModuleNVX*, VkResult> _vkCreateCuModuleNVX;
    private delegate* unmanaged[Cdecl]<VkDevice, VkCuFunctionCreateInfoNVX*, VkAllocationCallbacks*, VkCuFunctionNVX*, VkResult> _vkCreateCuFunctionNVX;
    private delegate* unmanaged[Cdecl]<VkDevice, VkCuModuleNVX, VkAllocationCallbacks*, void> _vkDestroyCuModuleNVX;
    private delegate* unmanaged[Cdecl]<VkDevice, VkCuFunctionNVX, VkAllocationCallbacks*, void> _vkDestroyCuFunctionNVX;
    private delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCuLaunchInfoNVX*, void> _vkCmdCuLaunchKernelNVX;

    public VkNvxBinaryImportExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkCreateCuModuleNVX = (delegate* unmanaged[Cdecl]<VkDevice, VkCuModuleCreateInfoNVX*, VkAllocationCallbacks*, VkCuModuleNVX*, VkResult>)loader.GetDeviceProcAddr(device, "vkCreateCuModuleNVX");
        _vkCreateCuFunctionNVX = (delegate* unmanaged[Cdecl]<VkDevice, VkCuFunctionCreateInfoNVX*, VkAllocationCallbacks*, VkCuFunctionNVX*, VkResult>)loader.GetDeviceProcAddr(device, "vkCreateCuFunctionNVX");
        _vkDestroyCuModuleNVX = (delegate* unmanaged[Cdecl]<VkDevice, VkCuModuleNVX, VkAllocationCallbacks*, void>)loader.GetDeviceProcAddr(device, "vkDestroyCuModuleNVX");
        _vkDestroyCuFunctionNVX = (delegate* unmanaged[Cdecl]<VkDevice, VkCuFunctionNVX, VkAllocationCallbacks*, void>)loader.GetDeviceProcAddr(device, "vkDestroyCuFunctionNVX");
        _vkCmdCuLaunchKernelNVX = (delegate* unmanaged[Cdecl]<VkCommandBuffer, VkCuLaunchInfoNVX*, void>)loader.GetDeviceProcAddr(device, "vkCmdCuLaunchKernelNVX");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateCuModuleNVX(VkDevice device, VkCuModuleCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuModuleNVX* pModule)
    {
        return _vkCreateCuModuleNVX(device, pCreateInfo, pAllocator, pModule);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateCuFunctionNVX(VkDevice device, VkCuFunctionCreateInfoNVX* pCreateInfo, VkAllocationCallbacks* pAllocator, VkCuFunctionNVX* pFunction)
    {
        return _vkCreateCuFunctionNVX(device, pCreateInfo, pAllocator, pFunction);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyCuModuleNVX(VkDevice device, VkCuModuleNVX module, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyCuModuleNVX(device, module, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyCuFunctionNVX(VkDevice device, VkCuFunctionNVX function, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyCuFunctionNVX(device, function, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkCmdCuLaunchKernelNVX(VkCommandBuffer commandBuffer, VkCuLaunchInfoNVX* pLaunchInfo)
    {
        _vkCmdCuLaunchKernelNVX(commandBuffer, pLaunchInfo);
    }
}