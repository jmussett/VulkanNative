using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDirectDriverLoadingInfoLUNARG
{
    public VkStructureType SType;
    public void* PNext;
    public VkDirectDriverLoadingFlagsLUNARG Flags;
    public delegate* unmanaged[Cdecl]<VkInstance, byte*, void> PfnGetInstanceProcAddr;
}