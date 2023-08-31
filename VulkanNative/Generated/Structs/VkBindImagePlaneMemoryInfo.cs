using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindImagePlaneMemoryInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageAspectFlags planeAspect;

    public VkBindImagePlaneMemoryInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_BIND_IMAGE_PLANE_MEMORY_INFO;
    }
}