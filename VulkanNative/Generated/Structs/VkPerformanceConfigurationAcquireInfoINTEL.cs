using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPerformanceConfigurationAcquireInfoINTEL
{
    public VkStructureType sType;
    public void* pNext;
    public VkPerformanceConfigurationTypeINTEL type;
}