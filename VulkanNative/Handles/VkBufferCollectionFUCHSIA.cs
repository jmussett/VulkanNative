using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkBufferCollectionFUCHSIA
{
    private readonly nint _handle;

    public VkBufferCollectionFUCHSIA(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkBufferCollectionFUCHSIA(nint handle)
    {
        return new VkBufferCollectionFUCHSIA(handle);
    }

    public static implicit operator nint(VkBufferCollectionFUCHSIA value)
    {
        return value._handle;
    }
}