using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceSynchronization2Features
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 synchronization2;
}