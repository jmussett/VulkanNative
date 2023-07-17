using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkEventCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkEventCreateFlags flags;
}