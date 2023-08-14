using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct MTLBuffer_id
{
    private readonly nint _value;

    public MTLBuffer_id(nint value)
    {
        _value = value;
    }

    public static implicit operator MTLBuffer_id(nint value)
    {
        return new MTLBuffer_id(value);
    }

    public static implicit operator nint(MTLBuffer_id value)
    {
        return value._value;
    }
}