using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerYcbcrConversionInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkSamplerYcbcrConversion conversion;
}