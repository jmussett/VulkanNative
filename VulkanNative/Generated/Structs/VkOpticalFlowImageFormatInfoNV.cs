using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOpticalFlowImageFormatInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkOpticalFlowUsageFlagsNV usage;
}