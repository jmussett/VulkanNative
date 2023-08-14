using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkDeferredOperationKHR
{
    private readonly nint _handle;

    public VkDeferredOperationKHR(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkDeferredOperationKHR(nint handle)
    {
        return new VkDeferredOperationKHR(handle);
    }

    public static implicit operator nint(VkDeferredOperationKHR value)
    {
        return value._handle;
    }
}