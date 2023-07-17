using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSparseImageMemoryBindInfo
{
    public VkImage image;
    public uint bindCount;
    public VkSparseImageMemoryBind* pBinds;
}