using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkColorBlendAdvancedEXT
{
    public VkBlendOp AdvancedBlendOp;
    public VkBool32 SrcPremultiplied;
    public VkBool32 DstPremultiplied;
    public VkBlendOverlapEXT BlendOverlap;
    public VkBool32 ClampResults;
}