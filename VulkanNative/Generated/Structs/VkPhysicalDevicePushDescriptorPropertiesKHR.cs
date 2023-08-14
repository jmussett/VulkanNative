using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDevicePushDescriptorPropertiesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint MaxPushDescriptors;
}