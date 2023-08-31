using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDepthBiasRepresentationInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDepthBiasRepresentationEXT depthBiasRepresentation;
    public VkBool32 depthBiasExact;
}