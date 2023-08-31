using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 descriptorSetHostMapping;

    public VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DESCRIPTOR_SET_HOST_MAPPING_FEATURES_VALVE;
    }
}