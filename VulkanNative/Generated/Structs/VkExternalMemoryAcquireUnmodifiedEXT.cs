using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalMemoryAcquireUnmodifiedEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 acquireUnmodifiedMemory;

    public VkExternalMemoryAcquireUnmodifiedEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_EXTERNAL_MEMORY_ACQUIRE_UNMODIFIED_EXT;
    }
}