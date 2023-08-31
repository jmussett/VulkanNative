using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineDynamicStateCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineDynamicStateCreateFlags flags;
    public uint dynamicStateCount;
    public VkDynamicState* pDynamicStates;

    public VkPipelineDynamicStateCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_DYNAMIC_STATE_CREATE_INFO;
    }
}