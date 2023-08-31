using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkColorBlendAdvancedEXT
{
    public VkBlendOp advancedBlendOp;
    public VkBool32 srcPremultiplied;
    public VkBool32 dstPremultiplied;
    public VkBlendOverlapEXT blendOverlap;
    public VkBool32 clampResults;
}