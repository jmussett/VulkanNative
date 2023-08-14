using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264SessionParametersAddInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint StdSPSCount;
    public nint* PStdSPSs;
    public uint StdPPSCount;
    public nint* PStdPPSs;
}