using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMaintenance4Features
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 maintenance4;
}