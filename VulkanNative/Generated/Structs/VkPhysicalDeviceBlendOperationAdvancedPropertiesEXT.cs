using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint AdvancedBlendMaxColorAttachments;
    public VkBool32 AdvancedBlendIndependentBlend;
    public VkBool32 AdvancedBlendNonPremultipliedSrcColor;
    public VkBool32 AdvancedBlendNonPremultipliedDstColor;
    public VkBool32 AdvancedBlendCorrelatedOverlap;
    public VkBool32 AdvancedBlendAllOperations;
}