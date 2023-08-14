using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct CAMetalLayer
{
    private readonly nint _value;

    public CAMetalLayer(nint value)
    {
        _value = value;
    }

    public static implicit operator CAMetalLayer(nint value)
    {
        return new CAMetalLayer(value);
    }

    public static implicit operator nint(CAMetalLayer value)
    {
        return value._value;
    }
}