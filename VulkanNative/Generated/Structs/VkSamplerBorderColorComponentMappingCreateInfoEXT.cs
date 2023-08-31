using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerBorderColorComponentMappingCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkComponentMapping components;
    public VkBool32 srgb;

    public VkSamplerBorderColorComponentMappingCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SAMPLER_BORDER_COLOR_COMPONENT_MAPPING_CREATE_INFO_EXT;
    }
}