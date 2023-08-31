using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264PictureInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public nint* pStdPictureInfo;
    public uint sliceCount;
    public uint* pSliceOffsets;
}