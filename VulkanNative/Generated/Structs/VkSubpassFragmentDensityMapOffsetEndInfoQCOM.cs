using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassFragmentDensityMapOffsetEndInfoQCOM
{
    public VkStructureType sType;
    public void* pNext;
    public uint fragmentDensityOffsetCount;
    public VkOffset2D* pFragmentDensityOffsets;
}