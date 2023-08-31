using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryGetRemoteAddressInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceMemory memory;
    public VkExternalMemoryHandleTypeFlags handleType;

    public VkMemoryGetRemoteAddressInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_GET_REMOTE_ADDRESS_INFO_NV;
    }
}