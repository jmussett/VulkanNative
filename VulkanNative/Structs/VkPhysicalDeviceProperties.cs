using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceProperties
{
    public uint apiVersion;
    public uint driverVersion;
    public uint vendorID;
    public uint deviceID;
    public VkPhysicalDeviceType deviceType;
    public fixed char deviceName[(int)VulkanApiConstants.VK_MAX_PHYSICAL_DEVICE_NAME_SIZE];
    public fixed byte pipelineCacheUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
    public VkPhysicalDeviceLimits limits;
    public VkPhysicalDeviceSparseProperties sparseProperties;
}