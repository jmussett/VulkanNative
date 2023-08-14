using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct AHardwareBuffer
{
    private readonly nint _value;

    public AHardwareBuffer(nint value)
    {
        _value = value;
    }

    public static implicit operator AHardwareBuffer(nint value)
    {
        return new AHardwareBuffer(value);
    }

    public static implicit operator nint(AHardwareBuffer value)
    {
        return value._value;
    }
}