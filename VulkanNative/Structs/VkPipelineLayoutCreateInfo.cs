using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineLayoutCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineLayoutCreateFlags Flags;
    public uint SetLayoutCount;
    public VkDescriptorSetLayout* PSetLayouts;
    public uint PushConstantRangeCount;
    public VkPushConstantRange* PPushConstantRanges;
}