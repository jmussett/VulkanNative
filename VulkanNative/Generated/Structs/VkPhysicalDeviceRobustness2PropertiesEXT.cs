using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRobustness2PropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceSize robustStorageBufferAccessSizeAlignment;
    public VkDeviceSize robustUniformBufferAccessSizeAlignment;

    public VkPhysicalDeviceRobustness2PropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ROBUSTNESS_2_PROPERTIES_EXT;
    }
}