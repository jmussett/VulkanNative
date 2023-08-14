using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkIndirectCommandsLayoutNV
{
    private readonly nint _handle;

    public VkIndirectCommandsLayoutNV(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkIndirectCommandsLayoutNV(nint handle)
    {
        return new VkIndirectCommandsLayoutNV(handle);
    }

    public static implicit operator nint(VkIndirectCommandsLayoutNV value)
    {
        return value._handle;
    }
}