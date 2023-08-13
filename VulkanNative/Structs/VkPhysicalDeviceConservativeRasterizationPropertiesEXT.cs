using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public float PrimitiveOverestimationSize;
    public float MaxExtraPrimitiveOverestimationSize;
    public float ExtraPrimitiveOverestimationSizeGranularity;
    public VkBool32 PrimitiveUnderestimation;
    public VkBool32 ConservativePointAndLineRasterization;
    public VkBool32 DegenerateTrianglesRasterized;
    public VkBool32 DegenerateLinesRasterized;
    public VkBool32 FullyCoveredFragmentShaderInputVariable;
    public VkBool32 ConservativeRasterizationPostDepthCoverage;
}