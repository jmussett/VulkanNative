using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageCopy2
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageSubresourceLayers srcSubresource;
    public VkOffset3D srcOffset;
    public VkImageSubresourceLayers dstSubresource;
    public VkOffset3D dstOffset;
    public VkExtent3D extent;

    public VkImageCopy2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_COPY_2;
    }
}