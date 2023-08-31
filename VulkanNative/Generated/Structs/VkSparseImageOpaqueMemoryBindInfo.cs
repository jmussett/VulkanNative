using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSparseImageOpaqueMemoryBindInfo
{
    public VkImage image;
    public uint bindCount;
    public VkSparseMemoryBind* pBinds;
}