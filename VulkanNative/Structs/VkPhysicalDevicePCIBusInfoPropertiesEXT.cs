using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePCIBusInfoPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint PciDomain;
    public uint PciBus;
    public uint PciDevice;
    public uint PciFunction;
}