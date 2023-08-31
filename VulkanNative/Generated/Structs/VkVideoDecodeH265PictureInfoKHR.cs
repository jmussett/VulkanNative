using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH265PictureInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public nint* pStdPictureInfo;
    public uint sliceSegmentCount;
    public uint* pSliceSegmentOffsets;
}