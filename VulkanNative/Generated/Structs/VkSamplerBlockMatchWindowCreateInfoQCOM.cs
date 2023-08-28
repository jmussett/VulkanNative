using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSamplerBlockMatchWindowCreateInfoQCOM
{
    public VkStructureType SType;
    public void* PNext;
    public VkExtent2D WindowExtent;
    public VkBlockMatchWindowCompareModeQCOM WindowCompareMode;
}