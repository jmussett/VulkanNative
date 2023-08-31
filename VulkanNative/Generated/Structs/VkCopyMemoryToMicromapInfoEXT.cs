using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyMemoryToMicromapInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceOrHostAddressConstKHR src;
    public VkMicromapEXT dst;
    public VkCopyMicromapModeEXT mode;
}