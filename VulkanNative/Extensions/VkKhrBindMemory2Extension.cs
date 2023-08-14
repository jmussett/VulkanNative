using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkKhrBindMemory2Extension
{
    private delegate* unmanaged[Cdecl]<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult> _vkBindBufferMemory2;
    private delegate* unmanaged[Cdecl]<VkDevice, uint, VkBindImageMemoryInfo*, VkResult> _vkBindImageMemory2;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkBindBufferMemory2(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos)
    {
        return _vkBindBufferMemory2(device, bindInfoCount, pBindInfos);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkBindImageMemory2(VkDevice device, uint bindInfoCount, VkBindImageMemoryInfo* pBindInfos)
    {
        return _vkBindImageMemory2(device, bindInfoCount, pBindInfos);
    }
}