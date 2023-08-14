using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkSwapchainKHR
{
    private readonly nint _handle;

    public VkSwapchainKHR(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkSwapchainKHR(nint handle)
    {
        return new VkSwapchainKHR(handle);
    }

    public static implicit operator nint(VkSwapchainKHR value)
    {
        return value._handle;
    }
}