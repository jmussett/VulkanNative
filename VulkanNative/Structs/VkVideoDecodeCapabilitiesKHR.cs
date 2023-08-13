using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeCapabilitiesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkVideoDecodeCapabilityFlagsKHR Flags;
}