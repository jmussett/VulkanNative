using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFenceGetWin32HandleInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkFence fence;
    public VkExternalFenceHandleTypeFlags handleType;

    public VkFenceGetWin32HandleInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_FENCE_GET_WIN32_HANDLE_INFO_KHR;
    }
}