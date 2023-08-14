using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyMicromapToMemoryInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkMicromapEXT Src;
    public VkDeviceOrHostAddressKHR Dst;
    public VkCopyMicromapModeEXT Mode;
}