using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceShaderClockFeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shaderSubgroupClock;
    public VkBool32 shaderDeviceClock;

    public VkPhysicalDeviceShaderClockFeaturesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SHADER_CLOCK_FEATURES_KHR;
    }
}