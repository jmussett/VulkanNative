using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportScreenBufferInfoQNX
{
    public VkStructureType SType;
    public void* PNext;
    public nint* Buffer;
}