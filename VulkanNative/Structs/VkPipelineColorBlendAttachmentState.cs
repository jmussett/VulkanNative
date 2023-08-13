using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineColorBlendAttachmentState
{
    public VkBool32 BlendEnable;
    public VkBlendFactor SrcColorBlendFactor;
    public VkBlendFactor DstColorBlendFactor;
    public VkBlendOp ColorBlendOp;
    public VkBlendFactor SrcAlphaBlendFactor;
    public VkBlendFactor DstAlphaBlendFactor;
    public VkBlendOp AlphaBlendOp;
    public VkColorComponentFlags ColorWriteMask;
}