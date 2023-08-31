using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalMemoryBufferCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkExternalMemoryHandleTypeFlags handleTypes;
}