using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassEndInfo
{
    public VkStructureType sType;
    public void* pNext;
}