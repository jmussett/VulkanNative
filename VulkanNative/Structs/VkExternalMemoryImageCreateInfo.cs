using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalMemoryImageCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkExternalMemoryHandleTypeFlags handleTypes;
}