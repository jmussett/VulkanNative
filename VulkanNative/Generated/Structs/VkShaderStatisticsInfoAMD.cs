using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkShaderStatisticsInfoAMD
{
    public VkShaderStageFlags shaderStageMask;
    public VkShaderResourceUsageAMD resourceUsage;
    public uint numPhysicalVgprs;
    public uint numPhysicalSgprs;
    public uint numAvailableVgprs;
    public uint numAvailableSgprs;
    public fixed uint computeWorkGroupSize[3];
}