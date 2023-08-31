using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOpticalFlowImageFormatPropertiesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkFormat format;
}