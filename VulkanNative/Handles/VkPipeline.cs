using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkPipeline
{
    private readonly nint _handle;

    public VkPipeline(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkPipeline(nint handle)
    {
        return new VkPipeline(handle);
    }

    public static implicit operator nint(VkPipeline value)
    {
        return value._handle;
    }
}