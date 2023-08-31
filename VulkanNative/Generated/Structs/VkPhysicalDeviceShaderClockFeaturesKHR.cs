using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderClockFeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderSubgroupClock;
    public VkBool32 shaderDeviceClock;
}