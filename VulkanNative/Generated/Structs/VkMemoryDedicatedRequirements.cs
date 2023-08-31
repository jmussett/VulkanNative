using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryDedicatedRequirements
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 prefersDedicatedAllocation;
    public VkBool32 requiresDedicatedAllocation;

    public VkMemoryDedicatedRequirements()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_DEDICATED_REQUIREMENTS;
    }
}