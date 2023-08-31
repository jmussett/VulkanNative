using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRobustnessCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineRobustnessBufferBehaviorEXT storageBuffers;
    public VkPipelineRobustnessBufferBehaviorEXT uniformBuffers;
    public VkPipelineRobustnessBufferBehaviorEXT vertexInputs;
    public VkPipelineRobustnessImageBehaviorEXT images;
}