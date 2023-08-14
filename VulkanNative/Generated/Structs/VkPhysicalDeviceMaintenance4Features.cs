using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMaintenance4Features
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 Maintenance4;
}