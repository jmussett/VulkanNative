using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoProfileInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkVideoCodecOperationFlagsKHR videoCodecOperation;
    public VkVideoChromaSubsamplingFlagsKHR chromaSubsampling;
    public VkVideoComponentBitDepthFlagsKHR lumaBitDepth;
    public VkVideoComponentBitDepthFlagsKHR chromaBitDepth;

    public VkVideoProfileInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_PROFILE_INFO_KHR;
    }
}