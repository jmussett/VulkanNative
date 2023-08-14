using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkCuModuleNVX
{
    private readonly nint _handle;

    public VkCuModuleNVX(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkCuModuleNVX(nint handle)
    {
        return new VkCuModuleNVX(handle);
    }

    public static implicit operator nint(VkCuModuleNVX value)
    {
        return value._handle;
    }
}