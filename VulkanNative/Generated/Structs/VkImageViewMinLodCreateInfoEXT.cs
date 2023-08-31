using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewMinLodCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public float minLod;

    public VkImageViewMinLodCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_VIEW_MIN_LOD_CREATE_INFO_EXT;
    }
}