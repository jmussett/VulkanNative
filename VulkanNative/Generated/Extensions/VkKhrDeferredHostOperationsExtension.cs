using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrDeferredHostOperationsExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkAllocationCallbacks*, VkDeferredOperationKHR*, VkResult> _vkCreateDeferredOperationKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkAllocationCallbacks*, void> _vkDestroyDeferredOperationKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, uint> _vkGetDeferredOperationMaxConcurrencyKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkResult> _vkGetDeferredOperationResultKHR;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkResult> _vkDeferredOperationJoinKHR;

    public VkKhrDeferredHostOperationsExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkCreateDeferredOperationKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkAllocationCallbacks*, VkDeferredOperationKHR*, VkResult>)loader.GetDeviceProcAddr(device, "vkCreateDeferredOperationKHR");
        _vkDestroyDeferredOperationKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkAllocationCallbacks*, void>)loader.GetDeviceProcAddr(device, "vkDestroyDeferredOperationKHR");
        _vkGetDeferredOperationMaxConcurrencyKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, uint>)loader.GetDeviceProcAddr(device, "vkGetDeferredOperationMaxConcurrencyKHR");
        _vkGetDeferredOperationResultKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkResult>)loader.GetDeviceProcAddr(device, "vkGetDeferredOperationResultKHR");
        _vkDeferredOperationJoinKHR = (delegate* unmanaged[Cdecl]<VkDevice, VkDeferredOperationKHR, VkResult>)loader.GetDeviceProcAddr(device, "vkDeferredOperationJoinKHR");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkCreateDeferredOperationKHR(VkDevice device, VkAllocationCallbacks* pAllocator, VkDeferredOperationKHR* pDeferredOperation)
    {
        return _vkCreateDeferredOperationKHR(device, pAllocator, pDeferredOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkDestroyDeferredOperationKHR(VkDevice device, VkDeferredOperationKHR operation, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyDeferredOperationKHR(device, operation, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public uint VkGetDeferredOperationMaxConcurrencyKHR(VkDevice device, VkDeferredOperationKHR operation)
    {
        return _vkGetDeferredOperationMaxConcurrencyKHR(device, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetDeferredOperationResultKHR(VkDevice device, VkDeferredOperationKHR operation)
    {
        return _vkGetDeferredOperationResultKHR(device, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkDeferredOperationJoinKHR(VkDevice device, VkDeferredOperationKHR operation)
    {
        return _vkDeferredOperationJoinKHR(device, operation);
    }
}