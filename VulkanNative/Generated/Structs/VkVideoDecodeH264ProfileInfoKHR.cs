using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264ProfileInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public nint stdProfileIdc;
    public VkVideoDecodeH264PictureLayoutFlagsKHR pictureLayout;

    public VkVideoDecodeH264ProfileInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_PROFILE_INFO_KHR;
    }
}