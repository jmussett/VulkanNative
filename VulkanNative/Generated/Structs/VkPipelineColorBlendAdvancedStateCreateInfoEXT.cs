using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 SrcPremultiplied;
    public VkBool32 DstPremultiplied;
    public VkBlendOverlapEXT BlendOverlap;
}