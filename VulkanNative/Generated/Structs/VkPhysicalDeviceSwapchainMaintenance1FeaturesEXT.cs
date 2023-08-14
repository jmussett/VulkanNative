using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 SwapchainMaintenance1;
}