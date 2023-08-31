using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageMemoryRequirementsInfo2
{
    public VkStructureType sType;
    public void* pNext;
    public VkImage image;

    public VkImageMemoryRequirementsInfo2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_MEMORY_REQUIREMENTS_INFO_2;
    }
}