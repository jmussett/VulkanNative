using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryZirconHandlePropertiesFUCHSIA
{
    public VkStructureType sType;
    public void* pNext;
    public uint memoryTypeBits;

    public VkMemoryZirconHandlePropertiesFUCHSIA()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_ZIRCON_HANDLE_PROPERTIES_FUCHSIA;
    }
}