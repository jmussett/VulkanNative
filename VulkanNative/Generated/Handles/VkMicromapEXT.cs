using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkMicromapEXT
{
    private readonly nint _handle;

    public VkMicromapEXT(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkMicromapEXT(nint handle)
    {
        return new VkMicromapEXT(handle);
    }

    public static implicit operator nint(VkMicromapEXT value)
    {
        return value._handle;
    }
}