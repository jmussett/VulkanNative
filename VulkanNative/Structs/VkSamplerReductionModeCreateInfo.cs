using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerReductionModeCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkSamplerReductionMode reductionMode;
}