using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceScalarBlockLayoutFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 scalarBlockLayout;

    public VkPhysicalDeviceScalarBlockLayoutFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_SCALAR_BLOCK_LAYOUT_FEATURES;
    }
}