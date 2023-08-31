using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceQueueInfo2
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceQueueCreateFlags flags;
    public uint queueFamilyIndex;
    public uint queueIndex;
}