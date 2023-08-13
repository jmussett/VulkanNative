using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineDepthStencilStateCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineDepthStencilStateCreateFlags Flags;
    public VkBool32 DepthTestEnable;
    public VkBool32 DepthWriteEnable;
    public VkCompareOp DepthCompareOp;
    public VkBool32 DepthBoundsTestEnable;
    public VkBool32 StencilTestEnable;
    public VkStencilOpState Front;
    public VkStencilOpState Back;
    public float MinDepthBounds;
    public float MaxDepthBounds;
}