using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDepthBiasRepresentationInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkDepthBiasRepresentationEXT DepthBiasRepresentation;
    public VkBool32 DepthBiasExact;
}