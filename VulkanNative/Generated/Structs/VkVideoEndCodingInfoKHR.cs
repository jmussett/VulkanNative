using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoEndCodingInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkVideoEndCodingFlagsKHR flags;

    public VkVideoEndCodingInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_END_CODING_INFO_KHR;
    }
}