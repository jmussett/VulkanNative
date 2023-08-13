using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSparseImageOpaqueMemoryBindInfo
{
    public VkImage Image;
    public uint BindCount;
    public VkSparseMemoryBind* PBinds;
}