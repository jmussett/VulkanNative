using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePipelineRobustnessPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessStorageBuffers;
    public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessUniformBuffers;
    public VkPipelineRobustnessBufferBehaviorEXT defaultRobustnessVertexInputs;
    public VkPipelineRobustnessImageBehaviorEXT defaultRobustnessImages;
}