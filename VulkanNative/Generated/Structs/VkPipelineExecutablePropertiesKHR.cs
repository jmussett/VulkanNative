using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineExecutablePropertiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkShaderStageFlags stages;
    public fixed byte name[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public fixed byte description[(int)VulkanApiConstants.VK_MAX_DESCRIPTION_SIZE];
    public uint subgroupSize;
}