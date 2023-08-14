using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoCodingControlInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkVideoCodingControlFlagsKHR Flags;
}