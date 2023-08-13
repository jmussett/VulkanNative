using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkInitializePerformanceApiInfoINTEL
{
    public VkStructureType SType;
    public void* PNext;
    public void* PUserData;
}