using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkSampleMask
{
    private readonly uint _value;

    public VkSampleMask(uint value)
    {
        _value = value;
    }

    public static implicit operator VkSampleMask(uint value)
    {
        return new VkSampleMask(value);
    }

    public static implicit operator uint(VkSampleMask value)
    {
        return value._value;
    }
}