using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkHostImageCopyDevicePerformanceQueryEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 optimalDeviceAccess;
    public VkBool32 identicalMemoryLayout;
}