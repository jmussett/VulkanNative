using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceAddressBindingReportFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 reportAddressBinding;

    public VkPhysicalDeviceAddressBindingReportFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_ADDRESS_BINDING_REPORT_FEATURES_EXT;
    }
}