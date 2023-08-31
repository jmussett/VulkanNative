using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceMemoryOpaqueCaptureAddressInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceMemory memory;

    public VkDeviceMemoryOpaqueCaptureAddressInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_MEMORY_OPAQUE_CAPTURE_ADDRESS_INFO;
    }
}