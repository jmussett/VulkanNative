using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH265PictureInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public nint* PStdPictureInfo;
    public uint SliceSegmentCount;
    public uint* PSliceSegmentOffsets;
}