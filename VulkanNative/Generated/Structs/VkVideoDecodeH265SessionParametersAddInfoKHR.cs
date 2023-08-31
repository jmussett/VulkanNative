using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH265SessionParametersAddInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint stdVPSCount;
    public nint* pStdVPSs;
    public uint stdSPSCount;
    public nint* pStdSPSs;
    public uint stdPPSCount;
    public nint* pStdPPSs;
}