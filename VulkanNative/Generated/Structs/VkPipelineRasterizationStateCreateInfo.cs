using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRasterizationStateCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineRasterizationStateCreateFlags Flags;
    public VkBool32 DepthClampEnable;
    public VkBool32 RasterizerDiscardEnable;
    public VkPolygonMode PolygonMode;
    public VkCullModeFlags CullMode;
    public VkFrontFace FrontFace;
    public VkBool32 DepthBiasEnable;
    public float DepthBiasConstantFactor;
    public float DepthBiasClamp;
    public float DepthBiasSlopeFactor;
    public float LineWidth;
}