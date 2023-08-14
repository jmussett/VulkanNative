using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct MTLTexture_id
{
    private readonly nint _value;

    public MTLTexture_id(nint value)
    {
        _value = value;
    }

    public static implicit operator MTLTexture_id(nint value)
    {
        return new MTLTexture_id(value);
    }

    public static implicit operator nint(MTLTexture_id value)
    {
        return value._value;
    }
}