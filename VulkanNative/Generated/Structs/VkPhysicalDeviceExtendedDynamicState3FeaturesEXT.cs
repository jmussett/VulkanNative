using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceExtendedDynamicState3FeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 ExtendedDynamicState3TessellationDomainOrigin;
    public VkBool32 ExtendedDynamicState3DepthClampEnable;
    public VkBool32 ExtendedDynamicState3PolygonMode;
    public VkBool32 ExtendedDynamicState3RasterizationSamples;
    public VkBool32 ExtendedDynamicState3SampleMask;
    public VkBool32 ExtendedDynamicState3AlphaToCoverageEnable;
    public VkBool32 ExtendedDynamicState3AlphaToOneEnable;
    public VkBool32 ExtendedDynamicState3LogicOpEnable;
    public VkBool32 ExtendedDynamicState3ColorBlendEnable;
    public VkBool32 ExtendedDynamicState3ColorBlendEquation;
    public VkBool32 ExtendedDynamicState3ColorWriteMask;
    public VkBool32 ExtendedDynamicState3RasterizationStream;
    public VkBool32 ExtendedDynamicState3ConservativeRasterizationMode;
    public VkBool32 ExtendedDynamicState3ExtraPrimitiveOverestimationSize;
    public VkBool32 ExtendedDynamicState3DepthClipEnable;
    public VkBool32 ExtendedDynamicState3SampleLocationsEnable;
    public VkBool32 ExtendedDynamicState3ColorBlendAdvanced;
    public VkBool32 ExtendedDynamicState3ProvokingVertexMode;
    public VkBool32 ExtendedDynamicState3LineRasterizationMode;
    public VkBool32 ExtendedDynamicState3LineStippleEnable;
    public VkBool32 ExtendedDynamicState3DepthClipNegativeOneToOne;
    public VkBool32 ExtendedDynamicState3ViewportWScalingEnable;
    public VkBool32 ExtendedDynamicState3ViewportSwizzle;
    public VkBool32 ExtendedDynamicState3CoverageToColorEnable;
    public VkBool32 ExtendedDynamicState3CoverageToColorLocation;
    public VkBool32 ExtendedDynamicState3CoverageModulationMode;
    public VkBool32 ExtendedDynamicState3CoverageModulationTableEnable;
    public VkBool32 ExtendedDynamicState3CoverageModulationTable;
    public VkBool32 ExtendedDynamicState3CoverageReductionMode;
    public VkBool32 ExtendedDynamicState3RepresentativeFragmentTestEnable;
    public VkBool32 ExtendedDynamicState3ShadingRateImageEnable;
}