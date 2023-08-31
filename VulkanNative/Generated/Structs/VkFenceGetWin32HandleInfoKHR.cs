using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFenceGetWin32HandleInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkFence fence;
    public VkExternalFenceHandleTypeFlags handleType;
}