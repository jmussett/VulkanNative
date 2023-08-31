using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceOpacityMicromapPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxOpacity2StateSubdivisionLevel;
    public uint maxOpacity4StateSubdivisionLevel;
}