using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageSparseMemoryRequirementsInfo2
{
    public VkStructureType sType;
    public void* pNext;
    public VkImage image;
}