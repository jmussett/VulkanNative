using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkDebugUtilsMessengerEXT
{
    private readonly nint _handle;

    public VkDebugUtilsMessengerEXT(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkDebugUtilsMessengerEXT(nint handle)
    {
        return new VkDebugUtilsMessengerEXT(handle);
    }

    public static implicit operator nint(VkDebugUtilsMessengerEXT value)
    {
        return value._handle;
    }
}