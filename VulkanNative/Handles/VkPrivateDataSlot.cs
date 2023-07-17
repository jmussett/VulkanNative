using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkPrivateDataSlot
{
    private readonly nint _handle;

    public VkPrivateDataSlot(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkPrivateDataSlot(nint handle)
    {
        return new VkPrivateDataSlot(handle);
    }

    public static implicit operator nint(VkPrivateDataSlot value)
    {
        return value._handle;
    }
}