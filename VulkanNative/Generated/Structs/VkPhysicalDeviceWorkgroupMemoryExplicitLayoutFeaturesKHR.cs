using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 workgroupMemoryExplicitLayout;
    public VkBool32 workgroupMemoryExplicitLayoutScalarBlockLayout;
    public VkBool32 workgroupMemoryExplicitLayout8BitAccess;
    public VkBool32 workgroupMemoryExplicitLayout16BitAccess;

    public VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_WORKGROUP_MEMORY_EXPLICIT_LAYOUT_FEATURES_KHR;
    }
}