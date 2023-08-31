using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryFdPropertiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint memoryTypeBits;

    public VkMemoryFdPropertiesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_FD_PROPERTIES_KHR;
    }
}