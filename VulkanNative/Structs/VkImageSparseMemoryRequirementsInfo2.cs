using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImageSparseMemoryRequirementsInfo2
{
    public VkStructureType SType;
    public void* PNext;
    public VkImage Image;
}