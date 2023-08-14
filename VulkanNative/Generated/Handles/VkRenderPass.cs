using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkRenderPass
{
    private readonly nint _handle;

    public VkRenderPass(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkRenderPass(nint handle)
    {
        return new VkRenderPass(handle);
    }

    public static implicit operator nint(VkRenderPass value)
    {
        return value._handle;
    }
}