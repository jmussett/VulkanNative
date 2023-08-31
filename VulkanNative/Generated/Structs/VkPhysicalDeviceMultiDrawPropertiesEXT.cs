using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMultiDrawPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxMultiDrawCount;

    public VkPhysicalDeviceMultiDrawPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MULTI_DRAW_PROPERTIES_EXT;
    }
}