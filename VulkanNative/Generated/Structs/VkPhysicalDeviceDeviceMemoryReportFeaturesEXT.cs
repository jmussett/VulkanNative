using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDeviceMemoryReportFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 deviceMemoryReport;

    public VkPhysicalDeviceDeviceMemoryReportFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DEVICE_MEMORY_REPORT_FEATURES_EXT;
    }
}