using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264DpbSlotInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public nint* pStdReferenceInfo;

    public VkVideoDecodeH264DpbSlotInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_DPB_SLOT_INFO_KHR;
    }
}