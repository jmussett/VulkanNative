using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageStencilUsageCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageUsageFlags stencilUsage;

    public VkImageStencilUsageCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_STENCIL_USAGE_CREATE_INFO;
    }
}