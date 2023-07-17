using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkBufferView
{
    private readonly nint _handle;

    public VkBufferView(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkBufferView(nint handle)
    {
        return new VkBufferView(handle);
    }

    public static implicit operator nint(VkBufferView value)
    {
        return value._handle;
    }
}