using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerCustomBorderColorCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkClearColorValue CustomBorderColor;
    public VkFormat Format;
}