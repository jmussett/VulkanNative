using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceProperties
{
    public uint ApiVersion;
    public uint DriverVersion;
    public uint VendorID;
    public uint DeviceID;
    public VkPhysicalDeviceType DeviceType;
    public fixed byte DeviceName[(int)VulkanApiConstants.VK_MAX_PHYSICAL_DEVICE_NAME_SIZE];
    public fixed byte PipelineCacheUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
    public VkPhysicalDeviceLimits Limits;
    public VkPhysicalDeviceSparseProperties SparseProperties;
}