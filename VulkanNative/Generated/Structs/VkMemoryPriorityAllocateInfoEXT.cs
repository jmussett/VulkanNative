using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryPriorityAllocateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public float priority;
}