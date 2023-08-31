using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoCodingControlInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkVideoCodingControlFlagsKHR flags;

    public VkVideoCodingControlInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_CODING_CONTROL_INFO_KHR;
    }
}