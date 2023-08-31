using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264PictureInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public nint* pStdPictureInfo;
    public uint sliceCount;
    public uint* pSliceOffsets;

    public VkVideoDecodeH264PictureInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PICTURE_INFO_KHR;
    }
}