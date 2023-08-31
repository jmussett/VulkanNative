using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceMemoryDecompressionPropertiesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkMemoryDecompressionMethodFlagsNV decompressionMethods;
    public ulong maxDecompressionIndirectCount;

    public VkPhysicalDeviceMemoryDecompressionPropertiesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_MEMORY_DECOMPRESSION_PROPERTIES_NV;
    }
}