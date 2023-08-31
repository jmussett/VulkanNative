using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkShaderModuleValidationCacheCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkValidationCacheEXT validationCache;
}