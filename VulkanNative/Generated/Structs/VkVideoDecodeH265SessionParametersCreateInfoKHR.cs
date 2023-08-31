using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH265SessionParametersCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxStdVPSCount;
    public uint maxStdSPSCount;
    public uint maxStdPPSCount;
    public VkVideoDecodeH265SessionParametersAddInfoKHR* pParametersAddInfo;

    public VkVideoDecodeH265SessionParametersCreateInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_H265_SESSION_PARAMETERS_CREATE_INFO_KHR;
    }
}