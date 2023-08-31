using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPresentIdKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint swapchainCount;
    public ulong* pPresentIds;

    public VkPresentIdKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PRESENT_ID_KHR;
    }
}