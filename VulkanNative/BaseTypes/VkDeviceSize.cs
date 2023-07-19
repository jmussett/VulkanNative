using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkDeviceSize
{
    private readonly ulong _value;

    public VkDeviceSize(ulong value)
    {
        _value = value;
    }

    public static implicit operator VkDeviceSize(ulong value)
    {
        return new VkDeviceSize(value);
    }

    public static implicit operator ulong(VkDeviceSize value)
    {
        return value._value;
    }
}