using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSynchronization2Features
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 Synchronization2;
}