using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageProcessingPropertiesQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxWeightFilterPhases;
    public VkExtent2D maxWeightFilterDimension;
    public VkExtent2D maxBlockMatchRegion;
    public VkExtent2D maxBoxFilterBlockSize;
}