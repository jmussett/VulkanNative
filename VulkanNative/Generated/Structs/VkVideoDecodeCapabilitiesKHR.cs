using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeCapabilitiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkVideoDecodeCapabilityFlagsKHR flags;

    public VkVideoDecodeCapabilitiesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_DECODE_CAPABILITIES_KHR;
    }
}