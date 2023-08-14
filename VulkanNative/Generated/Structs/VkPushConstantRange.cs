using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPushConstantRange
{
    public VkShaderStageFlags StageFlags;
    public uint Offset;
    public uint Size;
}