using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkQueueFamilyVideoPropertiesKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkVideoCodecOperationFlagsKHR videoCodecOperations;

    public VkQueueFamilyVideoPropertiesKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_QUEUE_FAMILY_VIDEO_PROPERTIES_KHR;
    }
}