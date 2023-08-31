using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryOpaqueCaptureAddressAllocateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public ulong opaqueCaptureAddress;

    public VkMemoryOpaqueCaptureAddressAllocateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MEMORY_OPAQUE_CAPTURE_ADDRESS_ALLOCATE_INFO;
    }
}