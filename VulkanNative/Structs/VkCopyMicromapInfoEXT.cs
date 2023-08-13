using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCopyMicromapInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkMicromapEXT Src;
    public VkMicromapEXT Dst;
    public VkCopyMicromapModeEXT Mode;
}