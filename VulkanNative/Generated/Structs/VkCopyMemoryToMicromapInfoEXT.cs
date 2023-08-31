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

    public VkCopyMemoryToMicromapInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COPY_MEMORY_TO_MICROMAP_INFO_EXT;
    }
}