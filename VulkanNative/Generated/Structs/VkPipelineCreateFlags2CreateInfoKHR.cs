using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCreateFlags2CreateInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineCreateFlags2KHR flags;

    public VkPipelineCreateFlags2CreateInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_CREATE_FLAGS_2_CREATE_INFO_KHR;
    }
}