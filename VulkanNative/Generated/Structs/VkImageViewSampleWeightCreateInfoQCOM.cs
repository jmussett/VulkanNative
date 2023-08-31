using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewSampleWeightCreateInfoQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkOffset2D filterCenter;
    public VkExtent2D filterSize;
    public uint numPhases;
}