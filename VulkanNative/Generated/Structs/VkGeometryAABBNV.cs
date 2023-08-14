using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkGeometryAABBNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkBuffer AabbData;
    public uint NumAABBs;
    public uint Stride;
    public VkDeviceSize Offset;
}