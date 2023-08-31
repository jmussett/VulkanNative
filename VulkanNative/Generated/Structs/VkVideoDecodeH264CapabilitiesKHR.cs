using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264CapabilitiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public nint maxLevelIdc;
    public VkOffset2D fieldOffsetGranularity;
}