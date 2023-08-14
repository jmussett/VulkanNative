using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerBorderColorComponentMappingCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkComponentMapping Components;
    public VkBool32 Srgb;
}