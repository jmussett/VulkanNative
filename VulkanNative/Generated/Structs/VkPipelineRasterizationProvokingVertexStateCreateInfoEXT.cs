using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineRasterizationProvokingVertexStateCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkProvokingVertexModeEXT ProvokingVertexMode;
}