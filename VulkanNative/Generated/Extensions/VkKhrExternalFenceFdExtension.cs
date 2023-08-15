using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrExternalFenceFdExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkImportFenceFdInfoKHR*, VkResult> _vkImportFenceFdKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkFenceGetFdInfoKHR*, nint*, VkResult> _vkGetFenceFdKHR;

    public VkKhrExternalFenceFdExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkImportFenceFdKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkImportFenceFdInfoKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkImportFenceFdKHR");
        _vkGetFenceFdKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkFenceGetFdInfoKHR*, nint*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetFenceFdKHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkImportFenceFdKHR(VkDevice device, VkImportFenceFdInfoKHR* pImportFenceFdInfo)
    {
        return _vkImportFenceFdKHR(device, pImportFenceFdInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetFenceFdKHR(VkDevice device, VkFenceGetFdInfoKHR* pGetFdInfo, nint* pFd)
    {
        return _vkGetFenceFdKHR(device, pGetFdInfo, pFd);
    }
}