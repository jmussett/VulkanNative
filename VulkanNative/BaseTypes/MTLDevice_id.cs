using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct MTLDevice_id
{
    private readonly nint _value;

    public MTLDevice_id(nint value)
    {
        _value = value;
    }

    public static implicit operator MTLDevice_id(nint value)
    {
        return new MTLDevice_id(value);
    }

    public static implicit operator nint(MTLDevice_id value)
    {
        return value._value;
    }
}