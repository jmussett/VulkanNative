using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindVideoSessionMemoryInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public uint MemoryBindIndex;
    public VkDeviceMemory Memory;
    public VkDeviceSize MemoryOffset;
    public VkDeviceSize MemorySize;
}