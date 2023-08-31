using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceIndexTypeUint8FeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 indexTypeUint8;
}