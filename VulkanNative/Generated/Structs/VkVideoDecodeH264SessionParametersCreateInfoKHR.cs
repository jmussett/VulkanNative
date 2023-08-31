using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264SessionParametersCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxStdSPSCount;
    public uint maxStdPPSCount;
    public VkVideoDecodeH264SessionParametersAddInfoKHR* pParametersAddInfo;

    public VkVideoDecodeH264SessionParametersCreateInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_CREATE_INFO_KHR;
    }
}