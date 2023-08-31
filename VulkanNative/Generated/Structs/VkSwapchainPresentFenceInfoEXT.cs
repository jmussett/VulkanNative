using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSwapchainPresentFenceInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint swapchainCount;
    public VkFence* pFences;
}