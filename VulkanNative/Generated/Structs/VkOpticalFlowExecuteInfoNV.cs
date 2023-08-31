using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOpticalFlowExecuteInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkOpticalFlowExecuteFlagsNV flags;
    public uint regionCount;
    public VkRect2D* pRegions;
}