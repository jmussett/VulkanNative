using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSubpassShadingPropertiesHUAWEI
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxSubpassShadingWorkgroupSizeAspectRatio;
}