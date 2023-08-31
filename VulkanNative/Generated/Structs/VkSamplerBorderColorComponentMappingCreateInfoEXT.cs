using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerBorderColorComponentMappingCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkComponentMapping components;
    public VkBool32 srgb;
}