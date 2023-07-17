using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFenceCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkFenceCreateFlags flags;
}