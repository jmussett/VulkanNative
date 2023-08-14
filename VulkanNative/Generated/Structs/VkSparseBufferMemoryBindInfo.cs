using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSparseBufferMemoryBindInfo
{
    public VkBuffer Buffer;
    public uint BindCount;
    public VkSparseMemoryBind* PBinds;
}