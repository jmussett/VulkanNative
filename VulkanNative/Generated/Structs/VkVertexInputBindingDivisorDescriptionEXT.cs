using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVertexInputBindingDivisorDescriptionEXT
{
    public uint binding;
    public uint divisor;
}