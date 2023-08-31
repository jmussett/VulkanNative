using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryGetZirconHandleInfoFUCHSIA
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceMemory memory;
    public VkExternalMemoryHandleTypeFlags handleType;

    public VkMemoryGetZirconHandleInfoFUCHSIA()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_GET_ZIRCON_HANDLE_INFO_FUCHSIA;
    }
}