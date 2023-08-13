using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSparseImageMemoryBind
{
    public VkImageSubresource Subresource;
    public VkOffset3D Offset;
    public VkExtent3D Extent;
    public VkDeviceMemory Memory;
    public VkDeviceSize MemoryOffset;
    public VkSparseMemoryBindFlags Flags;
}