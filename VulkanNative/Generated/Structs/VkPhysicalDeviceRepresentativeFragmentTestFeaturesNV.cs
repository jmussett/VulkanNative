using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 representativeFragmentTest;

    public VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_REPRESENTATIVE_FRAGMENT_TEST_FEATURES_NV;
    }
}