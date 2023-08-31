using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueueFamilyProperties2
{
    public VkStructureType sType;
    public void* pNext;
    public VkQueueFamilyProperties queueFamilyProperties;

    public VkQueueFamilyProperties2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_QUEUE_FAMILY_PROPERTIES_2;
    }
}