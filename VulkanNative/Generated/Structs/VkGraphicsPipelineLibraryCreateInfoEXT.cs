using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGraphicsPipelineLibraryCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkGraphicsPipelineLibraryFlagsEXT flags;

    public VkGraphicsPipelineLibraryCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_LIBRARY_CREATE_INFO_EXT;
    }
}