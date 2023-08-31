using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVertexInputBindingDescription
{
    public uint binding;
    public uint stride;
    public VkVertexInputRate inputRate;
}