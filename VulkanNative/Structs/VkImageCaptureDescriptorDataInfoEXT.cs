using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageCaptureDescriptorDataInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkImage Image;
}