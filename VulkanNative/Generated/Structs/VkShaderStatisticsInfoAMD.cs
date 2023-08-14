using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkShaderStatisticsInfoAMD
{
    public VkShaderStageFlags ShaderStageMask;
    public VkShaderResourceUsageAMD ResourceUsage;
    public uint NumPhysicalVgprs;
    public uint NumPhysicalSgprs;
    public uint NumAvailableVgprs;
    public uint NumAvailableSgprs;
    public fixed uint ComputeWorkGroupSize[3];
}