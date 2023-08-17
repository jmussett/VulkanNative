using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDriverProperties
{
    public VkStructureType SType;
    public void* PNext;
    public VkDriverId DriverID;
    public fixed byte DriverName[(int)VulkanApiConstants.VK_MAX_DRIVER_NAME_SIZE];
    public fixed byte DriverInfo[(int)VulkanApiConstants.VK_MAX_DRIVER_INFO_SIZE];
    public VkConformanceVersion ConformanceVersion;
}