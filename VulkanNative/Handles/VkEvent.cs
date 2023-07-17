using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkEvent
{
    private readonly nint _handle;

    public VkEvent(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkEvent(nint handle)
    {
        return new VkEvent(handle);
    }

    public static implicit operator nint(VkEvent value)
    {
        return value._handle;
    }
}