using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkColorBlendEquationEXT
{
    public VkBlendFactor srcColorBlendFactor;
    public VkBlendFactor dstColorBlendFactor;
    public VkBlendOp colorBlendOp;
    public VkBlendFactor srcAlphaBlendFactor;
    public VkBlendFactor dstAlphaBlendFactor;
    public VkBlendOp alphaBlendOp;
}