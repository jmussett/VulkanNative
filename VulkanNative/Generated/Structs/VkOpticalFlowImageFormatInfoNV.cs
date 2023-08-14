using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOpticalFlowImageFormatInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkOpticalFlowUsageFlagsNV Usage;
}