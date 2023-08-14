using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageViewSampleWeightCreateInfoQCOM
{
    public VkStructureType SType;
    public void* PNext;
    public VkOffset2D FilterCenter;
    public VkExtent2D FilterSize;
    public uint NumPhases;
}