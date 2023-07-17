using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueueFamilyProperties2
{
    public VkStructureType sType;
    public void* pNext;
    public VkQueueFamilyProperties queueFamilyProperties;
}