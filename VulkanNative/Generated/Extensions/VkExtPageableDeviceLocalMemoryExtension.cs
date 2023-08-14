﻿using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkExtPageableDeviceLocalMemoryExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, VkDeviceMemory, float, void> _vkSetDeviceMemoryPriorityEXT;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void VkSetDeviceMemoryPriorityEXT(VkDevice device, VkDeviceMemory memory, float priority)
    {
        _vkSetDeviceMemoryPriorityEXT(device, memory, priority);
    }
}