using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrTimelineSemaphoreExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkSemaphore, ulong*, VkResult> _vkGetSemaphoreCounterValue;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreWaitInfo*, ulong, VkResult> _vkWaitSemaphores;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreSignalInfo*, VkResult> _vkSignalSemaphore;

    public VkKhrTimelineSemaphoreExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkGetSemaphoreCounterValue = (delegate* unmanaged[Cdecl]<VkDevice, VkSemaphore, ulong*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetSemaphoreCounterValue");
        _vkWaitSemaphores = (delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreWaitInfo*, ulong, VkResult>)loader.GetDeviceProcAddr(device, "vkWaitSemaphores");
        _vkSignalSemaphore = (delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreSignalInfo*, VkResult>)loader.GetDeviceProcAddr(device, "vkSignalSemaphore");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkGetSemaphoreCounterValue(VkDevice device, VkSemaphore semaphore, ulong* pValue)
    {
        return _vkGetSemaphoreCounterValue(device, semaphore, pValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkWaitSemaphores(VkDevice device, VkSemaphoreWaitInfo* pWaitInfo, ulong timeout)
    {
        return _vkWaitSemaphores(device, pWaitInfo, timeout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkSignalSemaphore(VkDevice device, VkSemaphoreSignalInfo* pSignalInfo)
    {
        return _vkSignalSemaphore(device, pSignalInfo);
    }
}