using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCuModuleCreateInfoNVX
{
    public VkStructureType SType;
    public void* PNext;
    public nint DataSize;
    public void* PData;
}