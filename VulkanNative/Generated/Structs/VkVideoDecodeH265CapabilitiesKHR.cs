using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH265CapabilitiesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public nint MaxLevelIdc;
}