using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkShaderModuleValidationCacheCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkValidationCacheEXT validationCache;

    public VkShaderModuleValidationCacheCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SHADER_MODULE_VALIDATION_CACHE_CREATE_INFO_EXT;
    }
}