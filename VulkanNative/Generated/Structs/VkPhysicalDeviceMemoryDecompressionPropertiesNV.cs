using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMemoryDecompressionPropertiesNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkMemoryDecompressionMethodFlagsNV DecompressionMethods;
    public ulong MaxDecompressionIndirectCount;
}