using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEndCodingInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkVideoEndCodingFlagsKHR Flags;
}