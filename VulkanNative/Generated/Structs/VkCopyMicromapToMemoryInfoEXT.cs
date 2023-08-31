using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyMicromapToMemoryInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkMicromapEXT src;
    public VkDeviceOrHostAddressKHR dst;
    public VkCopyMicromapModeEXT mode;
}