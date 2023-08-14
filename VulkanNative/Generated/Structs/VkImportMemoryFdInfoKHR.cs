using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMemoryFdInfoKHR
{
    public VkStructureType SType;
    public void* PNext;
    public VkExternalMemoryHandleTypeFlags HandleType;
    public nint Fd;
}