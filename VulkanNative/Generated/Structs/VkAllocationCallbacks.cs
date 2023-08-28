using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAllocationCallbacks
{
    public void* PUserData;
    public delegate* unmanaged[Cdecl]<void*, nuint, nuint, VkSystemAllocationScope, void> PfnAllocation;
    public delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint, VkSystemAllocationScope, void> PfnReallocation;
    public delegate* unmanaged[Cdecl]<void*, void*, void> PfnFree;
    public delegate* unmanaged[Cdecl]<void*, nuint, VkInternalAllocationType, VkSystemAllocationScope, void> PfnInternalAllocation;
    public delegate* unmanaged[Cdecl]<void*, nuint, VkInternalAllocationType, VkSystemAllocationScope, void> PfnInternalFree;
}