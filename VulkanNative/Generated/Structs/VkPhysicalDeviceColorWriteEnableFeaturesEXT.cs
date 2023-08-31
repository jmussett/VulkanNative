using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceColorWriteEnableFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 colorWriteEnable;

    public VkPhysicalDeviceColorWriteEnableFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COLOR_WRITE_ENABLE_FEATURES_EXT;
    }
}