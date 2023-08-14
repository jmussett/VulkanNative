using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkImageViewCreateFlags Flags;
    public VkImage Image;
    public VkImageViewType ViewType;
    public VkFormat Format;
    public VkComponentMapping Components;
    public VkImageSubresourceRange SubresourceRange;
}