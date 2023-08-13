using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindBufferMemoryInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkBuffer Buffer;
    public VkDeviceMemory Memory;
    public VkDeviceSize MemoryOffset;
}