using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCuModuleCreateInfoNVX
{
    public VkStructureType SType;
    public void* PNext;
    public nuint DataSize;
    public void* PData;
}