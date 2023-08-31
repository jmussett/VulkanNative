using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryRequirements2
{
    public VkStructureType sType;
    public void* pNext;
    public VkMemoryRequirements memoryRequirements;

    public VkMemoryRequirements2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_REQUIREMENTS_2;
    }
}