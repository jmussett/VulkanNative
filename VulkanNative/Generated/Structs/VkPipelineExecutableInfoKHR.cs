using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineExecutableInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipeline pipeline;
    public uint executableIndex;
}