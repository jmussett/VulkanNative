using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferOpaqueCaptureAddressCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public ulong opaqueCaptureAddress;

    public VkBufferOpaqueCaptureAddressCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_BUFFER_OPAQUE_CAPTURE_ADDRESS_CREATE_INFO;
    }
}