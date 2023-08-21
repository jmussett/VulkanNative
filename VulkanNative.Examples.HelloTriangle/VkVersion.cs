namespace VulkanNative.Examples.HelloTriangle;

public readonly struct VkVersion
{
    private readonly uint _value;

    public VkVersion(uint major, uint minor, uint patch) => _value = (major << 22) | (minor << 12) | patch;

    private VkVersion(uint value) => _value = value;

    public static explicit operator VkVersion(uint val) => new(val);

    public static implicit operator uint(VkVersion version) => version._value;
}
