using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPipelineCoverageToColorStateCreateInfoNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkPipelineCoverageToColorStateCreateFlagsNV flags;
    public VkBool32 coverageToColorEnable;
    public uint coverageToColorLocation;
}