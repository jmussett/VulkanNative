using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceProtectedMemoryProperties
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 protectedNoFault;
}