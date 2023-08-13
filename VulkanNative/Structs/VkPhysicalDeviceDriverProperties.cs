using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDriverProperties
{
    public VkStructureType SType;
    public void* PNext;
    public VkDriverId DriverID;
    public fixed char DriverName[(int)VulkanApiConstants.VK_MAX_DRIVER_NAME_SIZE];
    public fixed char DriverInfo[(int)VulkanApiConstants.VK_MAX_DRIVER_INFO_SIZE];
    public VkConformanceVersion ConformanceVersion;
}