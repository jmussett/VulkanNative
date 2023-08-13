using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceOpacityMicromapPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint MaxOpacity2StateSubdivisionLevel;
    public uint MaxOpacity4StateSubdivisionLevel;
}