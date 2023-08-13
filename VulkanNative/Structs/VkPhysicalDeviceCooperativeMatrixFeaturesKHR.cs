using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceCooperativeMatrixFeaturesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 CooperativeMatrix;
    public VkBool32 CooperativeMatrixRobustBufferAccess;
}