using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSemaphoreTypeCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkSemaphoreType semaphoreType;
    public ulong initialValue;

    public VkSemaphoreTypeCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SEMAPHORE_TYPE_CREATE_INFO;
    }
}