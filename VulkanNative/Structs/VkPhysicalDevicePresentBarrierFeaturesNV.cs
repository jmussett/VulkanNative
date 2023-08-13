using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePresentBarrierFeaturesNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 PresentBarrier;
}