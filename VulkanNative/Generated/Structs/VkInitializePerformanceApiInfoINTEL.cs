using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkInitializePerformanceApiInfoINTEL
{
    public VkStructureType sType;
    public void* pNext;
    public void* pUserData;
}