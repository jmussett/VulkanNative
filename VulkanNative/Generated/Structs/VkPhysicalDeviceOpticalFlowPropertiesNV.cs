using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceOpticalFlowPropertiesNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkOpticalFlowGridSizeFlagsNV SupportedOutputGridSizes;
    public VkOpticalFlowGridSizeFlagsNV SupportedHintGridSizes;
    public VkBool32 HintSupported;
    public VkBool32 CostSupported;
    public VkBool32 BidirectionalFlowSupported;
    public VkBool32 GlobalFlowSupported;
    public uint MinWidth;
    public uint MinHeight;
    public uint MaxWidth;
    public uint MaxHeight;
    public uint MaxNumRegionsOfInterest;
}