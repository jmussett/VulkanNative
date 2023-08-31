using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderPassCreationControlEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 disallowMerging;
}