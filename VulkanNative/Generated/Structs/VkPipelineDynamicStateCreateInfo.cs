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
}