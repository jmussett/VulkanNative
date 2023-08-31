using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageProcessing2PropertiesQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkExtent2D maxBlockMatchWindow;

    public VkPhysicalDeviceImageProcessing2PropertiesQCOM()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_IMAGE_PROCESSING_2_PROPERTIES_QCOM;
    }
}