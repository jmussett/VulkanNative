using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 swapchainMaintenance1;
}