using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSemaphoreTypeCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkSemaphoreType semaphoreType;
    public ulong initialValue;
}