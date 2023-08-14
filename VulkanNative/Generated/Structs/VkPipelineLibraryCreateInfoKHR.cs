using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineLibraryCreateInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint LibraryCount;
    public VkPipeline* PLibraries;
}