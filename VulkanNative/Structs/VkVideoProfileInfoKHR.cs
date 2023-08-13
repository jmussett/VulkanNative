using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoProfileInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkVideoCodecOperationFlagsKHR VideoCodecOperation;
    public VkVideoChromaSubsamplingFlagsKHR ChromaSubsampling;
    public VkVideoComponentBitDepthFlagsKHR LumaBitDepth;
    public VkVideoComponentBitDepthFlagsKHR ChromaBitDepth;
}