using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImagePlaneMemoryRequirementsInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageAspectFlags planeAspect;

    public VkImagePlaneMemoryRequirementsInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_PLANE_MEMORY_REQUIREMENTS_INFO;
    }
}