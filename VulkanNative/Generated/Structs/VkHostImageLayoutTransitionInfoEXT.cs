using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkHostImageLayoutTransitionInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkImage image;
    public VkImageLayout oldLayout;
    public VkImageLayout newLayout;
    public VkImageSubresourceRange subresourceRange;
}