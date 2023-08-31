using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOpticalFlowSessionCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public uint width;
    public uint height;
    public VkFormat imageFormat;
    public VkFormat flowVectorFormat;
    public VkFormat costFormat;
    public VkOpticalFlowGridSizeFlagsNV outputGridSize;
    public VkOpticalFlowGridSizeFlagsNV hintGridSize;
    public VkOpticalFlowPerformanceLevelNV performanceLevel;
    public VkOpticalFlowSessionCreateFlagsNV flags;
}