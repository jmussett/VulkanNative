using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkOpticalFlowSessionNV
{
    private readonly nint _handle;

    public VkOpticalFlowSessionNV(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkOpticalFlowSessionNV(nint handle)
    {
        return new VkOpticalFlowSessionNV(handle);
    }

    public static implicit operator nint(VkOpticalFlowSessionNV value)
    {
        return value._handle;
    }
}