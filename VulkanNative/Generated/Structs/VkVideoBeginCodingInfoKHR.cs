using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoBeginCodingInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkVideoBeginCodingFlagsKHR flags;
    public VkVideoSessionKHR videoSession;
    public VkVideoSessionParametersKHR videoSessionParameters;
    public uint referenceSlotCount;
    public VkVideoReferenceSlotInfoKHR* pReferenceSlots;

    public VkVideoBeginCodingInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_BEGIN_CODING_INFO_KHR;
    }
}