using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferDeviceAddressInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkBuffer buffer;
}