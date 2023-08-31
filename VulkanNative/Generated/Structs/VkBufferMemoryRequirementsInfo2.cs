using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferMemoryRequirementsInfo2
{
    public VkStructureType sType;
    public void* pNext;
    public VkBuffer buffer;

    public VkBufferMemoryRequirementsInfo2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_MEMORY_REQUIREMENTS_INFO_2;
    }
}