using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct MTLSharedEvent_id
{
    private readonly nint _value;

    public MTLSharedEvent_id(nint value)
    {
        _value = value;
    }

    public static implicit operator MTLSharedEvent_id(nint value)
    {
        return new MTLSharedEvent_id(value);
    }

    public static implicit operator nint(MTLSharedEvent_id value)
    {
        return value._value;
    }
}