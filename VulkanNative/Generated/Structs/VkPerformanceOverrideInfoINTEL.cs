using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPerformanceOverrideInfoINTEL
{
    public VkStructureType sType;
    public void* pNext;
    public VkPerformanceOverrideTypeINTEL type;
    public VkBool32 enable;
    public ulong parameter;

    public VkPerformanceOverrideInfoINTEL()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PERFORMANCE_OVERRIDE_INFO_INTEL;
    }
}