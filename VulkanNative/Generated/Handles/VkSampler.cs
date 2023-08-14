using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkSampler
{
    private readonly nint _handle;

    public VkSampler(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkSampler(nint handle)
    {
        return new VkSampler(handle);
    }

    public static implicit operator nint(VkSampler value)
    {
        return value._handle;
    }
}