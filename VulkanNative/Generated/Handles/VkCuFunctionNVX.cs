using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkCuFunctionNVX
{
    private readonly nint _handle;

    public VkCuFunctionNVX(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkCuFunctionNVX(nint handle)
    {
        return new VkCuFunctionNVX(handle);
    }

    public static implicit operator nint(VkCuFunctionNVX value)
    {
        return value._handle;
    }
}