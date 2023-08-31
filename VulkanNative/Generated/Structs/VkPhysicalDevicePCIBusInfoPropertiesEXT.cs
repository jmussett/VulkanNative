using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePCIBusInfoPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint pciDomain;
    public uint pciBus;
    public uint pciDevice;
    public uint pciFunction;

    public VkPhysicalDevicePCIBusInfoPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_PCI_BUS_INFO_PROPERTIES_EXT;
    }
}