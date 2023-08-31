using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceUniformBufferStandardLayoutFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 uniformBufferStandardLayout;

    public VkPhysicalDeviceUniformBufferStandardLayoutFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_UNIFORM_BUFFER_STANDARD_LAYOUT_FEATURES;
    }
}