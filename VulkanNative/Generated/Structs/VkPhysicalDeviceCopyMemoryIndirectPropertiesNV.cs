using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceCopyMemoryIndirectPropertiesNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkQueueFlags SupportedQueues;
}