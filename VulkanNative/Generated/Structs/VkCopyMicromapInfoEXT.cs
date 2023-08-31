using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyMicromapInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkMicromapEXT src;
    public VkMicromapEXT dst;
    public VkCopyMicromapModeEXT mode;

    public VkCopyMicromapInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COPY_MICROMAP_INFO_EXT;
    }
}