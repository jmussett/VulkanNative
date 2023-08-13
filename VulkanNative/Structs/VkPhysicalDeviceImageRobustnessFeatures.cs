using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceImageRobustnessFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 robustImageAccess;
}