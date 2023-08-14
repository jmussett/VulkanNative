using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSwapchainPresentModesCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint PresentModeCount;
    public VkPresentModeKHR* PPresentModes;
}