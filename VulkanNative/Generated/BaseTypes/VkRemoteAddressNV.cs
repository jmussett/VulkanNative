using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct VkRemoteAddressNV
{
    private readonly void* _value;

    public VkRemoteAddressNV(void* value)
    {
        _value = value;
    }

    public static implicit operator VkRemoteAddressNV(void* value)
    {
        return new VkRemoteAddressNV(value);
    }

    public static implicit operator void*(VkRemoteAddressNV value)
    {
        return value._value;
    }
}