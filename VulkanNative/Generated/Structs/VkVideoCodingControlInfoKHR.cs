using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoCodingControlInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkVideoCodingControlFlagsKHR flags;
}