using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264CapabilitiesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public nint MaxLevelIdc;
    public VkOffset2D FieldOffsetGranularity;
}