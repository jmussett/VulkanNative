using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoPictureResourceInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkOffset2D CodedOffset;
    public VkExtent2D CodedExtent;
    public uint BaseArrayLayer;
    public VkImageView ImageViewBinding;
}