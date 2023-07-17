using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceImageMemoryRequirements
{
    public VkStructureType sType;
    public void* pNext;
    public VkImageCreateInfo* pCreateInfo;
    public VkImageAspectFlagBits planeAspect;
}