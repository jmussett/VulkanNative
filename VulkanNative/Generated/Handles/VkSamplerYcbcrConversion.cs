using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkSamplerYcbcrConversion
{
    private readonly nint _handle;

    public VkSamplerYcbcrConversion(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkSamplerYcbcrConversion(nint handle)
    {
        return new VkSamplerYcbcrConversion(handle);
    }

    public static implicit operator nint(VkSamplerYcbcrConversion value)
    {
        return value._handle;
    }
}