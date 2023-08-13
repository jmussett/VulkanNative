using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkEventCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkEventCreateFlags Flags;
}