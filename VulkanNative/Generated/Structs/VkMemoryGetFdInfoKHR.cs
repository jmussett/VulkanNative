using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryGetFdInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceMemory memory;
    public VkExternalMemoryHandleTypeFlags handleType;

    public VkMemoryGetFdInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_GET_FD_INFO_KHR;
    }
}