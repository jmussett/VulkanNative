using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH265SessionParametersAddInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint StdVPSCount;
    public nint* PStdVPSs;
    public uint StdSPSCount;
    public nint* PStdSPSs;
    public uint StdPPSCount;
    public nint* PStdPPSs;
}