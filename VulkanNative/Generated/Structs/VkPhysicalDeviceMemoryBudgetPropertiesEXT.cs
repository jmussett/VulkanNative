using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceSize* HeapBudget;
    public VkDeviceSize* HeapUsage;
}