using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindImageMemoryDeviceGroupInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint deviceIndexCount;
    public uint* pDeviceIndices;
    public uint splitInstanceBindRegionCount;
    public VkRect2D* pSplitInstanceBindRegions;
}