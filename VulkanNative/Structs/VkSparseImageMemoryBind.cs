using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSparseImageMemoryBind
{
    public VkImageSubresource subresource;
    public VkOffset3D offset;
    public VkExtent3D extent;
    public VkDeviceMemory memory;
    public VkDeviceSize memoryOffset;
    public VkSparseMemoryBindFlags flags;
}