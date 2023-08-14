using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineViewportDepthClipControlCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 NegativeOneToOne;
}