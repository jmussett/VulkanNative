using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceIDProperties
{
    public VkStructureType SType;
    public void* PNext;
    public fixed byte DeviceUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
    public fixed byte DriverUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
    public fixed byte DeviceLUID[(int)VulkanApiConstants.VK_LUID_SIZE];
    public uint DeviceNodeMask;
    public VkBool32 DeviceLUIDValid;
}