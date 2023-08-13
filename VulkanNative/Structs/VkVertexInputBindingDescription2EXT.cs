using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVertexInputBindingDescription2EXT
{
    public VkStructureType SType;
    public void* PNext;
    public uint Binding;
    public uint Stride;
    public VkVertexInputRate InputRate;
    public uint Divisor;
}