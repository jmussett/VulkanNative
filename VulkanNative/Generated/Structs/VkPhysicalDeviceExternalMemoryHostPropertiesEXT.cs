using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceSize minImportedHostPointerAlignment;

    public VkPhysicalDeviceExternalMemoryHostPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_EXTERNAL_MEMORY_HOST_PROPERTIES_EXT;
    }
}