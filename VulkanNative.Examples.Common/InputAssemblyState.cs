namespace VulkanNative.Examples.Common;

public struct InputAssemblyState
{
    public VkPrimitiveTopology Topology { get; set; }
    public bool PrimitiveRestartEnable { get; set; }
}
