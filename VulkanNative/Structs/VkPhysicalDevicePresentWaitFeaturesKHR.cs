using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePresentWaitFeaturesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 PresentWait;
}