using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDiscardRectanglePropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint MaxDiscardRectangles;
}