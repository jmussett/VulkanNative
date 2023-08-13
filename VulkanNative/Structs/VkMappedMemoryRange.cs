using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMappedMemoryRange
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceMemory Memory;
    public VkDeviceSize Offset;
    public VkDeviceSize Size;
}