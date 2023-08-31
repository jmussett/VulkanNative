using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVideoDecodeH265ProfileInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public nint stdProfileIdc;
}