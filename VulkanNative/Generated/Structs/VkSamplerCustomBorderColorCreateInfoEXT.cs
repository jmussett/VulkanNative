using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerCustomBorderColorCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkClearColorValue customBorderColor;
    public VkFormat format;

    public VkSamplerCustomBorderColorCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SAMPLER_CUSTOM_BORDER_COLOR_CREATE_INFO_EXT;
    }
}