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
}