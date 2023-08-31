using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH265ProfileInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public nint stdProfileIdc;

    public VkVideoDecodeH265ProfileInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_PROFILE_INFO_KHR;
    }
}