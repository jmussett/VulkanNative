using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOpticalFlowImageFormatPropertiesNV
{
    public VkStructureType SType;
    public void* PNext;
    public VkFormat Format;
}