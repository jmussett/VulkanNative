using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAllocationCallbacks
{
    public void* pUserData;
    public PFN_vkAllocationFunction pfnAllocation;
    public PFN_vkReallocationFunction pfnReallocation;
    public PFN_vkFreeFunction pfnFree;
    public PFN_vkInternalAllocationNotification pfnInternalAllocation;
    public PFN_vkInternalFreeNotification pfnInternalFree;
}