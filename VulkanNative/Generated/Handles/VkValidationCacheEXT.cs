using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkValidationCacheEXT
{
    private readonly nint _handle;

    public VkValidationCacheEXT(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkValidationCacheEXT(nint handle)
    {
        return new VkValidationCacheEXT(handle);
    }

    public static implicit operator nint(VkValidationCacheEXT value)
    {
        return value._handle;
    }
}