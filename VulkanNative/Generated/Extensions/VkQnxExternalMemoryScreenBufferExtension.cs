using System.Runtime.CompilerServices;

namespace VulkanNative;

public unsafe class VkQnxExternalMemoryScreenBufferExtension
{
    private delegate* unmanaged[Cdecl]<VkDevice, nint*, VkScreenBufferPropertiesQNX*, VkResult> _vkGetScreenBufferPropertiesQNX;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public VkResult VkGetScreenBufferPropertiesQNX(VkDevice device, nint* buffer, VkScreenBufferPropertiesQNX* pProperties)
    {
        return _vkGetScreenBufferPropertiesQNX(device, buffer, pProperties);
    }
}