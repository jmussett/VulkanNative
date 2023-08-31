using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryHostPointerPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint memoryTypeBits;

    public VkMemoryHostPointerPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_HOST_POINTER_PROPERTIES_EXT;
    }
}