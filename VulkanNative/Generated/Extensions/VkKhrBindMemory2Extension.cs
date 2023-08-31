using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrBindMemory2Extension
{
    private delegate* unmanaged[Cdecl]<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult> _vkBindBufferMemory2;
    private delegate* unmanaged[Cdecl]<VkDevice, uint, VkBindImageMemoryInfo*, VkResult> _vkBindImageMemory2;

    public VkKhrBindMemory2Extension(VkDevice device, IFunctionLoader loader)
    {
        _vkBindBufferMemory2 = (delegate* unmanaged[Cdecl]<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult>)loader.GetDeviceProcAddr(device, "vkBindBufferMemory2");
        _vkBindImageMemory2 = (delegate* unmanaged[Cdecl]<VkDevice, uint, VkBindImageMemoryInfo*, VkResult>)loader.GetDeviceProcAddr(device, "vkBindImageMemory2");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkBindBufferMemory2(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos)
    {
        return _vkBindBufferMemory2(device, bindInfoCount, pBindInfos);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult vkBindImageMemory2(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos)
    {
        return _vkBindImageMemory2(device, bindInfoCount, pBindInfos);
    }
}