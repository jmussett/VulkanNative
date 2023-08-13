using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkFlags64
{
    private readonly ulong _value;

    public VkFlags64(ulong value)
    {
        _value = value;
    }

    public static implicit operator VkFlags64(ulong value)
    {
        return new VkFlags64(value);
    }

    public static implicit operator ulong(VkFlags64 value)
    {
        return value._value;
    }
}