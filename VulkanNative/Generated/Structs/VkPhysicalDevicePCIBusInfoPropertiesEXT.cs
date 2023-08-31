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
}