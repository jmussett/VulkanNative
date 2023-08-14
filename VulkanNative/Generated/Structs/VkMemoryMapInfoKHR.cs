using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryMapInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkMemoryMapFlags Flags;
    public VkDeviceMemory Memory;
    public VkDeviceSize Offset;
    public VkDeviceSize Size;
}