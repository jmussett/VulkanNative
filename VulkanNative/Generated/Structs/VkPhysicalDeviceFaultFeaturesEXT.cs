using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFaultFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 DeviceFault;
    public VkBool32 DeviceFaultVendorBinary;
}