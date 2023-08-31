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

    public VkRenderPassSampleLocationsBeginInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_RENDER_PASS_SAMPLE_LOCATIONS_BEGIN_INFO_EXT;
    }
}