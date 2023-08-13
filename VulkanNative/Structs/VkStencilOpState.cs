using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkStencilOpState
{
    public VkStencilOp FailOp;
    public VkStencilOp PassOp;
    public VkStencilOp DepthFailOp;
    public VkCompareOp CompareOp;
    public uint CompareMask;
    public uint WriteMask;
    public uint Reference;
}