using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineInputAssemblyStateCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineInputAssemblyStateCreateFlags flags;
    public VkPrimitiveTopology topology;
    public VkBool32 primitiveRestartEnable;

    public VkPipelineInputAssemblyStateCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_INPUT_ASSEMBLY_STATE_CREATE_INFO;
    }
}