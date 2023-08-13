using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSparseImageFormatProperties2
{
    public VkStructureType SType;
    public void* PNext;
    public VkSparseImageFormatProperties Properties;
}