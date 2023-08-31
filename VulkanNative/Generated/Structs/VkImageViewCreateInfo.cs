using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageViewCreateFlags flags;
    public VkImage image;
    public VkImageViewType viewType;
    public VkFormat format;
    public VkComponentMapping components;
    public VkImageSubresourceRange subresourceRange;
}