using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPerformanceOverrideInfoINTEL
{
    public VkStructureType SType;
    public void* PNext;
    public VkPerformanceOverrideTypeINTEL Type;
    public VkBool32 Enable;
    public ulong Parameter;
}