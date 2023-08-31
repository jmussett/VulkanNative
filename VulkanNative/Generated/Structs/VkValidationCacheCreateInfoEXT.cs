using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkValidationCacheCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkValidationCacheCreateFlagsEXT flags;
    public nuint initialDataSize;
    public void* pInitialData;

    public VkValidationCacheCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_VALIDATION_CACHE_CREATE_INFO_EXT;
    }
}