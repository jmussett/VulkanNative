using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkReleaseSwapchainImagesInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkSwapchainKHR swapchain;
    public uint imageIndexCount;
    public uint* pImageIndices;
}