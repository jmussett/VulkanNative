using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMultiviewProperties
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxMultiviewViewCount;
    public uint maxMultiviewInstanceIndex;
}