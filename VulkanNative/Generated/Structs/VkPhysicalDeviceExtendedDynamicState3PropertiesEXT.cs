using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExtendedDynamicState3PropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 dynamicPrimitiveTopologyUnrestricted;
}