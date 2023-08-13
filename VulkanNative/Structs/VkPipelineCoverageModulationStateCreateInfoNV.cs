using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCoverageModulationStateCreateInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineCoverageModulationStateCreateFlagsNV Flags;
    public VkCoverageModulationModeNV CoverageModulationMode;
    public VkBool32 CoverageModulationTableEnable;
    public uint CoverageModulationTableCount;
    public float* PCoverageModulationTable;
}