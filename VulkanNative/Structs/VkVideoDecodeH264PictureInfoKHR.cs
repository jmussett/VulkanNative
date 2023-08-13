using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264PictureInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public nint* PStdPictureInfo;
    public uint SliceCount;
    public uint* PSliceOffsets;
}