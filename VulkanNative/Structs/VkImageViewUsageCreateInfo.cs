using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewUsageCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageUsageFlags usage;
}