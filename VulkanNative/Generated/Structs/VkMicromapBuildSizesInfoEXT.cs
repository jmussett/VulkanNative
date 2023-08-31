using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMicromapBuildSizesInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceSize micromapSize;
    public VkDeviceSize buildScratchSize;
    public VkBool32 discardable;

    public VkMicromapBuildSizesInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MICROMAP_BUILD_SIZES_INFO_EXT;
    }
}