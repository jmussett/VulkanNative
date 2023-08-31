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

    public VkCopyMicromapToMemoryInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COPY_MICROMAP_TO_MEMORY_INFO_EXT;
    }
}