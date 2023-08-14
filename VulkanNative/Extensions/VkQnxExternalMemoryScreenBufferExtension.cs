namespace VulkanNative;

public unsafe class VkQnxExternalMemoryScreenBufferExtension
{
    public delegate* unmanaged[Cdecl]<VkDevice, nint*, VkScreenBufferPropertiesQNX*, VkResult> vkGetScreenBufferPropertiesQNX;
}