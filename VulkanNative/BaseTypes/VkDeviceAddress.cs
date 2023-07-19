using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkDeviceAddress
{
    private readonly ulong _value;

    public VkDeviceAddress(ulong value)
    {
        _value = value;
    }

    public static implicit operator VkDeviceAddress(ulong value)
    {
        return new VkDeviceAddress(value);
    }

    public static implicit operator ulong(VkDeviceAddress value)
    {
        return value._value;
    }
}