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

    public VkPhysicalDeviceImageProcessingPropertiesQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_PROPERTIES_QCOM;
    }
}