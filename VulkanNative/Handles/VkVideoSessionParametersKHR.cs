using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkVideoSessionParametersKHR
{
    private readonly nint _handle;

    public VkVideoSessionParametersKHR(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkVideoSessionParametersKHR(nint handle)
    {
        return new VkVideoSessionParametersKHR(handle);
    }

    public static implicit operator nint(VkVideoSessionParametersKHR value)
    {
        return value._handle;
    }
}