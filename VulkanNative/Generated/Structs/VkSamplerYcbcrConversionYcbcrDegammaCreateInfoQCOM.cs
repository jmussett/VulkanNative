using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 EnableYDegamma;
    public VkBool32 EnableCbCrDegamma;
}