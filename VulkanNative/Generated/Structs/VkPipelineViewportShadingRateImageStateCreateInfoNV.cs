using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineViewportShadingRateImageStateCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 shadingRateImageEnable;
    public uint viewportCount;
    public VkShadingRatePaletteNV* pShadingRatePalettes;

    public VkPipelineViewportShadingRateImageStateCreateInfoNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_SHADING_RATE_IMAGE_STATE_CREATE_INFO_NV;
    }
}