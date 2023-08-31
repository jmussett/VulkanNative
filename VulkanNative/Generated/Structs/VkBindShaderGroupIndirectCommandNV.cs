using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBindShaderGroupIndirectCommandNV
{
    public uint groupIndex;
}