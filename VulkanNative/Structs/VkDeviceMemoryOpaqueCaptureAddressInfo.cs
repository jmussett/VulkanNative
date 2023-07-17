using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceMemoryOpaqueCaptureAddressInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceMemory memory;
}