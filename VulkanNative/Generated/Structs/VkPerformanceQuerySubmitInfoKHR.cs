using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPerformanceQuerySubmitInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint counterPassIndex;
}