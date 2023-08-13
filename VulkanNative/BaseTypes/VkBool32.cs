using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct VkBool32
{
    private readonly uint _value;

    public VkBool32(uint value)
    {
        _value = value;
    }

    public static implicit operator VkBool32(uint value)
    {
        return new VkBool32(value);
    }

    public static implicit operator uint(VkBool32 value)
    {
        return value._value;
    }
}