using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewCaptureDescriptorDataInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageView imageView;
}