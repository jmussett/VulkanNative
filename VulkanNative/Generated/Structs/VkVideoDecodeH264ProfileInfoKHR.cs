using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH264ProfileInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public nint StdProfileIdc;
    public VkVideoDecodeH264PictureLayoutFlagsKHR PictureLayout;
}