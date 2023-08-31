using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferDeviceAddressInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkBuffer buffer;

    public VkBufferDeviceAddressInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_DEVICE_ADDRESS_INFO;
    }
}