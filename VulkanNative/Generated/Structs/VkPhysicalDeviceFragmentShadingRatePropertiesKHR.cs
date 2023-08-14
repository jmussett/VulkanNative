using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkExtent2D MinFragmentShadingRateAttachmentTexelSize;
    public VkExtent2D MaxFragmentShadingRateAttachmentTexelSize;
    public uint MaxFragmentShadingRateAttachmentTexelSizeAspectRatio;
    public VkBool32 PrimitiveFragmentShadingRateWithMultipleViewports;
    public VkBool32 LayeredShadingRateAttachments;
    public VkBool32 FragmentShadingRateNonTrivialCombinerOps;
    public VkExtent2D MaxFragmentSize;
    public uint MaxFragmentSizeAspectRatio;
    public uint MaxFragmentShadingRateCoverageSamples;
    public VkSampleCountFlags MaxFragmentShadingRateRasterizationSamples;
    public VkBool32 FragmentShadingRateWithShaderDepthStencilWrites;
    public VkBool32 FragmentShadingRateWithSampleMask;
    public VkBool32 FragmentShadingRateWithShaderSampleMask;
    public VkBool32 FragmentShadingRateWithConservativeRasterization;
    public VkBool32 FragmentShadingRateWithFragmentShaderInterlock;
    public VkBool32 FragmentShadingRateWithCustomSampleLocations;
    public VkBool32 FragmentShadingRateStrictMultiplyCombiner;
}