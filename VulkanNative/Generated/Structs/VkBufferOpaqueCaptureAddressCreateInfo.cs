using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferOpaqueCaptureAddressCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public ulong opaqueCaptureAddress;
}