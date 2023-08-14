using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRobustnessCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineRobustnessBufferBehaviorEXT StorageBuffers;
    public VkPipelineRobustnessBufferBehaviorEXT UniformBuffers;
    public VkPipelineRobustnessBufferBehaviorEXT VertexInputs;
    public VkPipelineRobustnessImageBehaviorEXT Images;
}