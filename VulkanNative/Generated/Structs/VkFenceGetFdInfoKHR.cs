using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFenceGetFdInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkFence fence;
    public VkExternalFenceHandleTypeFlags handleType;
}