using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkInstance
{
    private readonly nint _handle;

    public VkInstance(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkInstance(nint handle)
    {
        return new VkInstance(handle);
    }

    public static implicit operator nint(VkInstance value)
    {
        return value._handle;
    }
}