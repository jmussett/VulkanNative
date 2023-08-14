using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public readonly struct VkAccelerationStructureKHR
{
    private readonly nint _handle;

    public VkAccelerationStructureKHR(nint handle)
    {
        _handle = handle;
    }

    public static implicit operator VkAccelerationStructureKHR(nint handle)
    {
        return new VkAccelerationStructureKHR(handle);
    }

    public static implicit operator nint(VkAccelerationStructureKHR value)
    {
        return value._handle;
    }
}