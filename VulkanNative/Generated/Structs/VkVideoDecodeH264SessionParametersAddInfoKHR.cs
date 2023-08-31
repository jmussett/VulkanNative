using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264SessionParametersAddInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint stdSPSCount;
    public nint* pStdSPSs;
    public uint stdPPSCount;
    public nint* pStdPPSs;

    public VkVideoDecodeH264SessionParametersAddInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_H264_SESSION_PARAMETERS_ADD_INFO_KHR;
    }
}