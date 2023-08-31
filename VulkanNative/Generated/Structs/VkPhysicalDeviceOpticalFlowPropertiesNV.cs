using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceOpticalFlowPropertiesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkOpticalFlowGridSizeFlagsNV supportedOutputGridSizes;
    public VkOpticalFlowGridSizeFlagsNV supportedHintGridSizes;
    public VkBool32 hintSupported;
    public VkBool32 costSupported;
    public VkBool32 bidirectionalFlowSupported;
    public VkBool32 globalFlowSupported;
    public uint minWidth;
    public uint minHeight;
    public uint maxWidth;
    public uint maxHeight;
    public uint maxNumRegionsOfInterest;

    public VkPhysicalDeviceOpticalFlowPropertiesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_OPTICAL_FLOW_PROPERTIES_NV;
    }
}