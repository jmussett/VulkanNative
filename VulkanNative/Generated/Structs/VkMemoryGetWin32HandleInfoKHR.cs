using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryGetWin32HandleInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceMemory memory;
    public VkExternalMemoryHandleTypeFlags handleType;

    public VkMemoryGetWin32HandleInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_GET_WIN32_HANDLE_INFO_KHR;
    }
}