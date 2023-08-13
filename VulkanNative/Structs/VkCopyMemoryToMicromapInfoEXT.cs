using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyMemoryToMicromapInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceOrHostAddressConstKHR Src;
    public VkMicromapEXT Dst;
    public VkCopyMicromapModeEXT Mode;
}