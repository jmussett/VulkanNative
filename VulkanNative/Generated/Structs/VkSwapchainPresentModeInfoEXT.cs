using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSwapchainPresentModeInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint SwapchainCount;
    public VkPresentModeKHR* PPresentModes;
}