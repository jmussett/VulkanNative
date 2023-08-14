using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkPerformanceConfigurationINTEL
{
    private readonly nint _handle;

    public VkPerformanceConfigurationINTEL(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkPerformanceConfigurationINTEL(nint handle)
    {
        return new VkPerformanceConfigurationINTEL(handle);
    }

    public static implicit operator nint(VkPerformanceConfigurationINTEL value)
    {
        return value._handle;
    }
}