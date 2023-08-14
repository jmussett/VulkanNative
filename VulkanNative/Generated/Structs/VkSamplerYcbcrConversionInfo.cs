using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerYcbcrConversionInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkSamplerYcbcrConversion Conversion;
}