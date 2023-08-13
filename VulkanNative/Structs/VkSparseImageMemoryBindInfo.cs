using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSparseImageMemoryBindInfo
{
    public VkImage Image;
    public uint BindCount;
    public VkSparseImageMemoryBind* PBinds;
}