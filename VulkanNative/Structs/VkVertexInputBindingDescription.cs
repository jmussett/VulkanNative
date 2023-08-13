using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVertexInputBindingDescription
{
    public uint Binding;
    public uint Stride;
    public VkVertexInputRate InputRate;
}