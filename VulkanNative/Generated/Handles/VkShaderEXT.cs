using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkShaderEXT
{
    private readonly nint _handle;

    public VkShaderEXT(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkShaderEXT(nint handle)
    {
        return new VkShaderEXT(handle);
    }

    public static implicit operator nint(VkShaderEXT value)
    {
        return value._handle;
    }
}