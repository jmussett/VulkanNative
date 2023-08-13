using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCoverageToColorStateCreateInfoNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkPipelineCoverageToColorStateCreateFlagsNV Flags;
    public VkBool32 CoverageToColorEnable;
    public uint CoverageToColorLocation;
}