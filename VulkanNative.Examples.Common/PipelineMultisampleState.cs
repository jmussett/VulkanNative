namespace VulkanNative.Examples.Common;

public struct PipelineMultisampleState
{
    public VkSampleCountFlags RasterizationSamples { get; set; }
    public bool SampleShadingEnable { get; set; }
    public float MinSampleShading { get; set; }
    //public VkSampleMask* pSampleMask; TODO
    public bool AlphaToCoverageEnable { get; set; }
    public bool AlphaToOneEnable { get; set; }
}
