using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264CapabilitiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public nint maxLevelIdc;
    public VkOffset2D fieldOffsetGranularity;

    public VkVideoDecodeH264CapabilitiesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_CAPABILITIES_KHR;
    }
}