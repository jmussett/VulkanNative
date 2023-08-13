using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264SessionParametersCreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint MaxStdSPSCount;
    public uint MaxStdPPSCount;
    public VkVideoDecodeH264SessionParametersAddInfoKHR* PParametersAddInfo;
}