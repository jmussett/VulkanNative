using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSemaphoreCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkSemaphoreCreateFlags flags;
}