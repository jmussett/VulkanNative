using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkQueue
{
    private readonly nint _handle;

    public VkQueue(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkQueue(nint handle)
    {
        return new VkQueue(handle);
    }

    public static implicit operator nint(VkQueue value)
    {
        return value._handle;
    }
}