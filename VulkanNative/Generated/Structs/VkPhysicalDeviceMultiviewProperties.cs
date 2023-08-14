using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMultiviewProperties
{
    public VkStructureType SType;
    public void* PNext;
    public uint MaxMultiviewViewCount;
    public uint MaxMultiviewInstanceIndex;
}