using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkReleaseSwapchainImagesInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkSwapchainKHR Swapchain;
    public uint ImageIndexCount;
    public uint* PImageIndices;
}