using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDriverProperties
{
    public VkStructureType sType;
    public void* pNext;
    public VkDriverId driverID;
    public fixed char driverName[(int)VulkanApiConstants.VK_MAX_DRIVER_NAME_SIZE];
    public fixed char driverInfo[(int)VulkanApiConstants.VK_MAX_DRIVER_INFO_SIZE];
    public VkConformanceVersion conformanceVersion;
}