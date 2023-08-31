using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkVertexInputBindingDescription2EXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint binding;
    public uint stride;
    public VkVertexInputRate inputRate;
    public uint divisor;
}