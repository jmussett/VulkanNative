using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFaultFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 deviceFault;
    public VkBool32 deviceFaultVendorBinary;
}