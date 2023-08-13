using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassSampleLocationsBeginInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint AttachmentInitialSampleLocationsCount;
    public VkAttachmentSampleLocationsEXT* PAttachmentInitialSampleLocations;
    public uint PostSubpassSampleLocationsCount;
    public VkSubpassSampleLocationsEXT* PPostSubpassSampleLocations;
}