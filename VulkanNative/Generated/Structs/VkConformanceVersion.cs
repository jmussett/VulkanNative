using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkConformanceVersion
{
    public byte major;
    public byte minor;
    public byte subminor;
    public byte patch;
}