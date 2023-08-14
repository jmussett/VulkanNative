using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct IOSurfaceRef
{
    private readonly nint _value;

    public IOSurfaceRef(nint value)
    {
        _value = value;
    }

    public static implicit operator IOSurfaceRef(nint value)
    {
        return new IOSurfaceRef(value);
    }

    public static implicit operator nint(IOSurfaceRef value)
    {
        return value._value;
    }
}