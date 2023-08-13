using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageStencilUsageCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageUsageFlags StencilUsage;
}