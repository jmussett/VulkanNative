using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264ProfileInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public nint stdProfileIdc;
    public VkVideoDecodeH264PictureLayoutFlagsKHR pictureLayout;
}