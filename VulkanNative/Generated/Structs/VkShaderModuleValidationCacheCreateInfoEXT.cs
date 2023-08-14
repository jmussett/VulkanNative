using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkShaderModuleValidationCacheCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkValidationCacheEXT ValidationCache;
}