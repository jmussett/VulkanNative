using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryGetFdInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceMemory memory;
    public VkExternalMemoryHandleTypeFlags handleType;
}