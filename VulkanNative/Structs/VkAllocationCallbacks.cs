using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAllocationCallbacks
{
    public void* pUserData;
    public delegate* unmanaged[Cdecl]<void*, nint, nint, VkSystemAllocationScope, void> pfnAllocation;
    public delegate* unmanaged[Cdecl]<void*, void*, nint, nint, VkSystemAllocationScope, void> pfnReallocation;
    public delegate* unmanaged[Cdecl]<void*, void*, void> pfnFree;
    public delegate* unmanaged[Cdecl]<void*, nint, VkInternalAllocationType, VkSystemAllocationScope, void> pfnInternalAllocation;
    public delegate* unmanaged[Cdecl]<void*, nint, VkInternalAllocationType, VkSystemAllocationScope, void> pfnInternalFree;
}