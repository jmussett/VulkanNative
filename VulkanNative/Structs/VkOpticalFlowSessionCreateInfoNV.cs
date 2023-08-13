using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOpticalFlowSessionCreateInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public uint Width;
    public uint Height;
    public VkFormat ImageFormat;
    public VkFormat FlowVectorFormat;
    public VkFormat CostFormat;
    public VkOpticalFlowGridSizeFlagsNV OutputGridSize;
    public VkOpticalFlowGridSizeFlagsNV HintGridSize;
    public VkOpticalFlowPerformanceLevelNV PerformanceLevel;
    public VkOpticalFlowSessionCreateFlagsNV Flags;
}