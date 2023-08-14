using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkDevice
{
    private readonly nint _handle;

    public VkDevice(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkDevice(nint handle)
    {
        return new VkDevice(handle);
    }

    public static implicit operator nint(VkDevice value)
    {
        return value._handle;
    }
}