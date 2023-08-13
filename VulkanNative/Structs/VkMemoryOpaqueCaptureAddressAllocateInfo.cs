using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMemoryOpaqueCaptureAddressAllocateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public ulong OpaqueCaptureAddress;
}