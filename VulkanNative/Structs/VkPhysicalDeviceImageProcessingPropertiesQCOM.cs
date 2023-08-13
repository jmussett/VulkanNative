using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageProcessingPropertiesQCOM
{
    public VkStructureType SType;
    public void* PNext;
    public uint MaxWeightFilterPhases;
    public VkExtent2D MaxWeightFilterDimension;
    public VkExtent2D MaxBlockMatchRegion;
    public VkExtent2D MaxBoxFilterBlockSize;
}