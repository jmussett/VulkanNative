using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindImageMemoryDeviceGroupInfo
{
    public VkStructureType SType;
    public void* PNext;
    public uint DeviceIndexCount;
    public uint* PDeviceIndices;
    public uint SplitInstanceBindRegionCount;
    public VkRect2D* PSplitInstanceBindRegions;
}