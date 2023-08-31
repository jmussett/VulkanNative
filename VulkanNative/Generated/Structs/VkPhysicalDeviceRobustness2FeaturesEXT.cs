using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRobustness2FeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 robustBufferAccess2;
    public VkBool32 robustImageAccess2;
    public VkBool32 nullDescriptor;
}