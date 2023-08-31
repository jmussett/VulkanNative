using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPushConstantRange
{
    public VkShaderStageFlags stageFlags;
    public uint offset;
    public uint size;
}