using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEndCodingInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkVideoEndCodingFlagsKHR flags;
}