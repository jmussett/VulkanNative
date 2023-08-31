using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeCapabilitiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkVideoDecodeCapabilityFlagsKHR flags;
}