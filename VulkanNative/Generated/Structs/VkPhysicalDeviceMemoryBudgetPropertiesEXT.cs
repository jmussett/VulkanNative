using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceSize* heapBudget;
    public VkDeviceSize* heapUsage;

    public VkPhysicalDeviceMemoryBudgetPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_BUDGET_PROPERTIES_EXT;
    }
}