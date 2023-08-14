using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMultiDrawPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint MaxMultiDrawCount;
}