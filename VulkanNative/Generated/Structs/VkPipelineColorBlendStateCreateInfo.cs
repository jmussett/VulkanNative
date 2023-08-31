using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineColorBlendStateCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineColorBlendStateCreateFlags flags;
    public VkBool32 logicOpEnable;
    public VkLogicOp logicOp;
    public uint attachmentCount;
    public VkPipelineColorBlendAttachmentState* pAttachments;
    public fixed float blendConstants[4];
}