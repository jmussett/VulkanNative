using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOpticalFlowExecuteInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkOpticalFlowExecuteFlagsNV Flags;
    public uint RegionCount;
    public VkRect2D* PRegions;
}