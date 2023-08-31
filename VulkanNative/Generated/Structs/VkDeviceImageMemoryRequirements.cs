using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceImageMemoryRequirements
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageCreateInfo* pCreateInfo;
    public VkImageAspectFlags planeAspect;

    public VkDeviceImageMemoryRequirements()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_IMAGE_MEMORY_REQUIREMENTS;
    }
}