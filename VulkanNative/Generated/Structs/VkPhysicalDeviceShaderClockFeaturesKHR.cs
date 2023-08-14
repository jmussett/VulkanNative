using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderClockFeaturesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 ShaderSubgroupClock;
    public VkBool32 ShaderDeviceClock;
}