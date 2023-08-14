using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtHostQueryResetExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkQueryPool, uint, uint, void> _vkResetQueryPool;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkResetQueryPool(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount)
    {
        _vkResetQueryPool(device, queryPool, firstQuery, queryCount);
    }
}