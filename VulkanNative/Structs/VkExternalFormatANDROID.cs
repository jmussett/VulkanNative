using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalFormatANDROID
{
    public VkStructureType SType;
    public void* PNext;
    public ulong ExternalFormat;
}