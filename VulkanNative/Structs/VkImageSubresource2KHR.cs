using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageSubresource2KHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageSubresource ImageSubresource;
}