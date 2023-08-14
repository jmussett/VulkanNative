using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkPipelineLayout
{
    private readonly nint _handle;

    public VkPipelineLayout(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkPipelineLayout(nint handle)
    {
        return new VkPipelineLayout(handle);
    }

    public static implicit operator nint(VkPipelineLayout value)
    {
        return value._handle;
    }
}