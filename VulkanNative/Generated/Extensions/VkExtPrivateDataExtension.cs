using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtPrivateDataExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkPrivateDataSlotCreateInfo*, VkAllocationCallbacks*, VkPrivateDataSlot*, VkResult> _vkCreatePrivateDataSlot;
    private delegate* unmanaged[Cdecl]<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void> _vkDestroyPrivateDataSlot;
    private delegate* unmanaged[Cdecl]<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong, VkResult> _vkSetPrivateData;
    private delegate* unmanaged[Cdecl]<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong*, void> _vkGetPrivateData;

    public VkExtPrivateDataExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkCreatePrivateDataSlot = (delegate* unmanaged[Cdecl]<VkDevice, VkPrivateDataSlotCreateInfo*, VkAllocationCallbacks*, VkPrivateDataSlot*, VkResult>)loader.GetDeviceProcAddr(device, "vkCreatePrivateDataSlot");
        _vkDestroyPrivateDataSlot = (delegate* unmanaged[Cdecl]<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void>)loader.GetDeviceProcAddr(device, "vkDestroyPrivateDataSlot");
        _vkSetPrivateData = (delegate* unmanaged[Cdecl]<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong, VkResult>)loader.GetDeviceProcAddr(device, "vkSetPrivateData");
        _vkGetPrivateData = (delegate* unmanaged[Cdecl]<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong*, void>)loader.GetDeviceProcAddr(device, "vkGetPrivateData");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkCreatePrivateDataSlot(VkDevice device, VkPrivateDataSlotCreateInfo* pCreateInfo, VkAllocationCallbacks* pAllocator, VkPrivateDataSlot* pPrivateDataSlot)
    {
        return _vkCreatePrivateDataSlot(device, pCreateInfo, pAllocator, pPrivateDataSlot);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkDestroyPrivateDataSlot(VkDevice device, VkPrivateDataSlot privateDataSlot, VkAllocationCallbacks* pAllocator)
    {
        _vkDestroyPrivateDataSlot(device, privateDataSlot, pAllocator);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkSetPrivateData(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong data)
    {
        return _vkSetPrivateData(device, objectType, objectHandle, privateDataSlot, data);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void vkGetPrivateData(VkDevice device, VkObjectType objectType, ulong objectHandle, VkPrivateDataSlot privateDataSlot, ulong* pData)
    {
        _vkGetPrivateData(device, objectType, objectHandle, privateDataSlot, pData);
    }
}