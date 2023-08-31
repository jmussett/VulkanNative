using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRasterizationStateCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineRasterizationStateCreateFlags flags;
    public VkBool32 depthClampEnable;
    public VkBool32 rasterizerDiscardEnable;
    public VkPolygonMode polygonMode;
    public VkCullModeFlags cullMode;
    public VkFrontFace frontFace;
    public VkBool32 depthBiasEnable;
    public float depthBiasConstantFactor;
    public float depthBiasClamp;
    public float depthBiasSlopeFactor;
    public float lineWidth;
}