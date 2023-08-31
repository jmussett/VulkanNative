using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoProfileListInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint profileCount;
    public VkVideoProfileInfoKHR* pProfiles;

    public VkVideoProfileListInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VIDEO_PROFILE_LIST_INFO_KHR;
    }
}