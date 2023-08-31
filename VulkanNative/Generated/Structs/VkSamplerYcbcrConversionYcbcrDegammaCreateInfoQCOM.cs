using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 enableYDegamma;
    public VkBool32 enableCbCrDegamma;
}