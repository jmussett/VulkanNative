using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrTimelineSemaphoreExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkSemaphore, ulong*, VkResult> _vkGetSemaphoreCounterValue;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreWaitInfo*, ulong, VkResult> _vkWaitSemaphores;
    private delegate* unmanaged[Cdecl]<VkDevice, VkSemaphoreSignalInfo*, VkResult> _vkSignalSemaphore;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetSemaphoreCounterValue(VkDevice device, VkSemaphore semaphore, ulong* pValue)
    {
        return _vkGetSemaphoreCounterValue(device, semaphore, pValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkWaitSemaphores(VkDevice device, VkSemaphoreWaitInfo* pWaitInfo, ulong timeout)
    {
        return _vkWaitSemaphores(device, pWaitInfo, timeout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkSignalSemaphore(VkDevice device, VkSemaphoreSignalInfo* pSignalInfo)
    {
        return _vkSignalSemaphore(device, pSignalInfo);
    }
}