using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceQueueInfo2
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceQueueCreateFlags Flags;
    public uint QueueFamilyIndex;
    public uint QueueIndex;
}