using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMemoryDecompressionPropertiesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkMemoryDecompressionMethodFlagsNV decompressionMethods;
    public ulong maxDecompressionIndirectCount;
}