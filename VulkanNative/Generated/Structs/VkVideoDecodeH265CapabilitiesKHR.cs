using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH265CapabilitiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public nint maxLevelIdc;

    public VkVideoDecodeH265CapabilitiesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_CAPABILITIES_KHR;
    }
}