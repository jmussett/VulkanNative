using VulkanNative.Abstractions;
using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkQnxExternalMemoryScreenBufferExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, nint*, VkScreenBufferPropertiesQNX*, VkResult> _vkGetScreenBufferPropertiesQNX;

    public VkQnxExternalMemoryScreenBufferExtension(VkDevice device, IVulkanLoader loader)
    {
        _vkGetScreenBufferPropertiesQNX = (delegate* unmanaged[Cdecl]<VkDevice, nint*, VkScreenBufferPropertiesQNX*, VkResult>)loader.GetDeviceProcAddr(device, "vkGetScreenBufferPropertiesQNX");
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetScreenBufferPropertiesQNX(VkDevice device, nint* buffer, VkScreenBufferPropertiesQNX* pProperties)
    {
        return _vkGetScreenBufferPropertiesQNX(device, buffer, pProperties);
    }
}