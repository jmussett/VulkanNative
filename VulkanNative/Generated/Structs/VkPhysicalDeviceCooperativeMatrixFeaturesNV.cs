using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceCooperativeMatrixFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 cooperativeMatrix;
    public VkBool32 cooperativeMatrixRobustBufferAccess;

    public VkPhysicalDeviceCooperativeMatrixFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_COOPERATIVE_MATRIX_FEATURES_NV;
    }
}