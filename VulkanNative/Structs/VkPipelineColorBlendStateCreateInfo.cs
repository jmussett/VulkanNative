using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineColorBlendStateCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineColorBlendStateCreateFlags Flags;
    public VkBool32 LogicOpEnable;
    public VkLogicOp LogicOp;
    public uint AttachmentCount;
    public VkPipelineColorBlendAttachmentState* PAttachments;
    public fixed float BlendConstants[4];
}