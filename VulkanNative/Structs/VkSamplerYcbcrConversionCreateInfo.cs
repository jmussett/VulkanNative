using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerYcbcrConversionCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkFormat Format;
    public VkSamplerYcbcrModelConversion YcbcrModel;
    public VkSamplerYcbcrRange YcbcrRange;
    public VkComponentMapping Components;
    public VkChromaLocation XChromaOffset;
    public VkChromaLocation YChromaOffset;
    public VkFilter ChromaFilter;
    public VkBool32 ForceExplicitReconstruction;
}