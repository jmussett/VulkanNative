using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePushDescriptorPropertiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint maxPushDescriptors;
}