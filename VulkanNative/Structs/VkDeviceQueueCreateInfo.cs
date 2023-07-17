using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceQueueCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceQueueCreateFlags flags;
    public uint queueFamilyIndex;
    public uint queueCount;
    public float* pQueuePriorities;
}