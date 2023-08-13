using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMaintenance5PropertiesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 EarlyFragmentMultisampleCoverageAfterSampleCounting;
    public VkBool32 EarlyFragmentSampleMaskTestBeforeSampleCounting;
    public VkBool32 DepthStencilSwizzleOneSupport;
    public VkBool32 PolygonModePointSize;
    public VkBool32 NonStrictSinglePixelWideLinesUseParallelogram;
    public VkBool32 NonStrictWideLinesUseParallelogram;
}