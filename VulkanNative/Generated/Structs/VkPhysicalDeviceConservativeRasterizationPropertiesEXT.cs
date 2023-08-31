using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public float primitiveOverestimationSize;
    public float maxExtraPrimitiveOverestimationSize;
    public float extraPrimitiveOverestimationSizeGranularity;
    public VkBool32 primitiveUnderestimation;
    public VkBool32 conservativePointAndLineRasterization;
    public VkBool32 degenerateTrianglesRasterized;
    public VkBool32 degenerateLinesRasterized;
    public VkBool32 fullyCoveredFragmentShaderInputVariable;
    public VkBool32 conservativeRasterizationPostDepthCoverage;
}