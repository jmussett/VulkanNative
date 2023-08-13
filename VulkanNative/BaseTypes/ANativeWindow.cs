using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct ANativeWindow
{
    private readonly nint _value;

    public ANativeWindow(nint value)
    {
        _value = value;
    }

    public static implicit operator ANativeWindow(nint value)
    {
        return new ANativeWindow(value);
    }

    public static implicit operator nint(ANativeWindow value)
    {
        return value._value;
    }
}