using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPresentTimesInfoGOOGLE
{
    public VkStructureType sType;
    public void* pNext;
    public uint swapchainCount;
    public VkPresentTimeGOOGLE* pTimes;

    public VkPresentTimesInfoGOOGLE()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PRESENT_TIMES_INFO_GOOGLE;
    }
}