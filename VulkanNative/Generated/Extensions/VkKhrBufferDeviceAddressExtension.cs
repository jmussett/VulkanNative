using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrBufferDeviceAddressExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, VkDeviceAddress> _vkGetBufferDeviceAddress;
    private delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, ulong> _vkGetBufferOpaqueCaptureAddress;
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemoryOpaqueCaptureAddressInfo*, ulong> _vkGetDeviceMemoryOpaqueCaptureAddress;

    public VkKhrBufferDeviceAddressExtension(VkDevice device, IFunctionLoader loader)
    {
        _vkGetBufferDeviceAddress = (delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, VkDeviceAddress>)loader.GetDeviceProcAddr(device, "vkGetBufferDeviceAddress");
        _vkGetBufferOpaqueCaptureAddress = (delegate* unmanaged[Cdecl]<VkDevice, VkBufferDeviceAddressInfo*, ulong>)loader.GetDeviceProcAddr(device, "vkGetBufferOpaqueCaptureAddress");
        _vkGetDeviceMemoryOpaqueCaptureAddress = (delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemoryOpaqueCaptureAddressInfo*, ulong>)loader.GetDeviceProcAddr(device, "vkGetDeviceMemoryOpaqueCaptureAddress");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkDeviceAddress VkGetBufferDeviceAddress(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
    {
        return _vkGetBufferDeviceAddress(device, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ulong VkGetBufferOpaqueCaptureAddress(VkDevice device, VkBufferDeviceAddressInfo* pInfo)
    {
        return _vkGetBufferOpaqueCaptureAddress(device, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ulong VkGetDeviceMemoryOpaqueCaptureAddress(VkDevice device, VkDeviceMemoryOpaqueCaptureAddressInfo* pInfo)
    {
        return _vkGetDeviceMemoryOpaqueCaptureAddress(device, pInfo);
    }
}