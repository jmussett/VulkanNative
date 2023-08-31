using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceIDProperties
{
    public VkStructureType sType;
    public void* pNext;
    public fixed byte deviceUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
    public fixed byte driverUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
    public fixed byte deviceLUID[(int)VulkanApiConstants.VK_LUID_SIZE];
    public uint deviceNodeMask;
    public VkBool32 deviceLUIDValid;

    public VkPhysicalDeviceIDProperties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ID_PROPERTIES;
    }
}