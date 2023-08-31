using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerCustomBorderColorCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkClearColorValue customBorderColor;
    public VkFormat format;
}