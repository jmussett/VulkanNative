using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH265PictureInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public nint* pStdPictureInfo;
    public uint sliceSegmentCount;
    public uint* pSliceSegmentOffsets;

    public VkVideoDecodeH265PictureInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PICTURE_INFO_KHR;
    }
}