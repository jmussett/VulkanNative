namespace VulkanNative.Examples.Common.Utility;

public readonly struct VulkanVersion
{
    private readonly uint _value;

    public VulkanVersion(uint major, uint minor, uint patch) => _value = (major << 22) | (minor << 12) | patch;

    private VulkanVersion(uint value) => _value = value;

    public static explicit operator VulkanVersion(uint val) => new(val);

    public static implicit operator uint(VulkanVersion version) => version._value;
}
