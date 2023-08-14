using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineDynamicStateCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineDynamicStateCreateFlags Flags;
    public uint DynamicStateCount;
    public VkDynamicState* PDynamicStates;
}