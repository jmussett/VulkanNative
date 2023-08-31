using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineLibraryCreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint libraryCount;
    public VkPipeline* pLibraries;

    public VkPipelineLibraryCreateInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_LIBRARY_CREATE_INFO_KHR;
    }
}