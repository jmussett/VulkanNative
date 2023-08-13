using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageStencilUsageCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageUsageFlags stencilUsage;
}