using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewUsageCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageUsageFlags usage;

    public VkImageViewUsageCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_VIEW_USAGE_CREATE_INFO;
    }
}