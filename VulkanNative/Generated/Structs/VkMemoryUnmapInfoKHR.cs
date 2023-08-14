using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryUnmapInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkMemoryUnmapFlagsKHR Flags;
    public VkDeviceMemory Memory;
}