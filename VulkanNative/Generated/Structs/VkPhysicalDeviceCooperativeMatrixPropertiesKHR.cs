using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceCooperativeMatrixPropertiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkShaderStageFlags cooperativeMatrixSupportedStages;
}