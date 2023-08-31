using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSparseMemoryBind
{
    public VkDeviceSize resourceOffset;
    public VkDeviceSize size;
    public VkDeviceMemory memory;
    public VkDeviceSize memoryOffset;
    public VkSparseMemoryBindFlags flags;
}