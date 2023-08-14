using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkSemaphore
{
    private readonly nint _handle;

    public VkSemaphore(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkSemaphore(nint handle)
    {
        return new VkSemaphore(handle);
    }

    public static implicit operator nint(VkSemaphore value)
    {
        return value._handle;
    }
}