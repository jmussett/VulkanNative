using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceScalarBlockLayoutFeatures
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 ScalarBlockLayout;
}