using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkHostImageCopyDevicePerformanceQueryEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 OptimalDeviceAccess;
    public VkBool32 IdenticalMemoryLayout;
}