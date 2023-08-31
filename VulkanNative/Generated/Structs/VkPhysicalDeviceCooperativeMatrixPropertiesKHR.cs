using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceCooperativeMatrixPropertiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkShaderStageFlags cooperativeMatrixSupportedStages;

    public VkPhysicalDeviceCooperativeMatrixPropertiesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_PROPERTIES_KHR;
    }
}