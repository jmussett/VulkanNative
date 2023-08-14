using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct MTLCommandQueue_id
{
    private readonly nint _value;

    public MTLCommandQueue_id(nint value)
    {
        _value = value;
    }

    public static implicit operator MTLCommandQueue_id(nint value)
    {
        return new MTLCommandQueue_id(value);
    }

    public static implicit operator nint(MTLCommandQueue_id value)
    {
        return value._value;
    }
}