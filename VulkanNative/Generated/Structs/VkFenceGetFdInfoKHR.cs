using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFenceGetFdInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public VkFence fence;
    public VkExternalFenceHandleTypeFlags handleType;

    public VkFenceGetFdInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_FENCE_GET_FD_INFO_KHR;
    }
}