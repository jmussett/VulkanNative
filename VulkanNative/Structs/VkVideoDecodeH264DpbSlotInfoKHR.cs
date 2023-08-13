using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264DpbSlotInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public nint* PStdReferenceInfo;
}