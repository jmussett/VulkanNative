using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAttachmentSampleLocationsEXT
{
    public uint AttachmentIndex;
    public VkSampleLocationsInfoEXT SampleLocationsInfo;
}