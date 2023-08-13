using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct VkFlags
{
    private readonly uint _value;

    public VkFlags(uint value)
    {
        _value = value;
    }

    public static implicit operator VkFlags(uint value)
    {
        return new VkFlags(value);
    }

    public static implicit operator uint(VkFlags value)
    {
        return value._value;
    }
}