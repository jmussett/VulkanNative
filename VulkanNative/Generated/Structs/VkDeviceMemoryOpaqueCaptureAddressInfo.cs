using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceMemoryOpaqueCaptureAddressInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceMemory Memory;
}