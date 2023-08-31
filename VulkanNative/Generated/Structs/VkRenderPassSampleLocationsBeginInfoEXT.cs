using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassSampleLocationsBeginInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint attachmentInitialSampleLocationsCount;
    public VkAttachmentSampleLocationsEXT* pAttachmentInitialSampleLocations;
    public uint postSubpassSampleLocationsCount;
    public VkSubpassSampleLocationsEXT* pPostSubpassSampleLocations;
}