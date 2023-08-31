using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueueFamilyProperties
{
    public VkQueueFlags queueFlags;
    public uint queueCount;
    public uint timestampValidBits;
    public VkExtent3D minImageTransferGranularity;
}