using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceCooperativeMatrixPropertiesNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkShaderStageFlags CooperativeMatrixSupportedStages;
}