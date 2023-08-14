using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSparseMemoryBind
{
    public VkDeviceSize ResourceOffset;
    public VkDeviceSize Size;
    public VkDeviceMemory Memory;
    public VkDeviceSize MemoryOffset;
    public VkSparseMemoryBindFlags Flags;
}