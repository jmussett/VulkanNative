using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkExtent2D minFragmentDensityTexelSize;
    public VkExtent2D maxFragmentDensityTexelSize;
    public VkBool32 fragmentDensityInvocations;
}