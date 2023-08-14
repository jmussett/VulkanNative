using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkPipelineCache
{
    private readonly nint _handle;

    public VkPipelineCache(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkPipelineCache(nint handle)
    {
        return new VkPipelineCache(handle);
    }

    public static implicit operator nint(VkPipelineCache value)
    {
        return value._handle;
    }
}