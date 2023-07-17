using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageMemoryRequirementsInfo2
{
    public VkStructureType sType;
    public void* pNext;
    public VkImage image;
}