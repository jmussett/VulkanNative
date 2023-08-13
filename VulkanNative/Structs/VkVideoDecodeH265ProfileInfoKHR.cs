using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH265ProfileInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public nint StdProfileIdc;
}