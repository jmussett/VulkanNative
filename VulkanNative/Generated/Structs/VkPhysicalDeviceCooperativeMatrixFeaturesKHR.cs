using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceCooperativeMatrixFeaturesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 cooperativeMatrix;
    public VkBool32 cooperativeMatrixRobustBufferAccess;
}