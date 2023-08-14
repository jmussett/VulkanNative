using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePipelineRobustnessPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineRobustnessBufferBehaviorEXT DefaultRobustnessStorageBuffers;
    public VkPipelineRobustnessBufferBehaviorEXT DefaultRobustnessUniformBuffers;
    public VkPipelineRobustnessBufferBehaviorEXT DefaultRobustnessVertexInputs;
    public VkPipelineRobustnessImageBehaviorEXT DefaultRobustnessImages;
}