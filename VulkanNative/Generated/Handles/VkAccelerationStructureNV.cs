using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkAccelerationStructureNV
{
    private readonly nint _handle;

    public VkAccelerationStructureNV(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkAccelerationStructureNV(nint handle)
    {
        return new VkAccelerationStructureNV(handle);
    }

    public static implicit operator nint(VkAccelerationStructureNV value)
    {
        return value._handle;
    }
}