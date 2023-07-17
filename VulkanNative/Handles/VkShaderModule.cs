using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkShaderModule
{
    private readonly nint _handle;

    public VkShaderModule(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkShaderModule(nint handle)
    {
        return new VkShaderModule(handle);
    }

    public static implicit operator nint(VkShaderModule value)
    {
        return value._handle;
    }
}