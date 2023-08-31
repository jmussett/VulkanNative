using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGraphicsPipelineLibraryCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkGraphicsPipelineLibraryFlagsEXT flags;
}