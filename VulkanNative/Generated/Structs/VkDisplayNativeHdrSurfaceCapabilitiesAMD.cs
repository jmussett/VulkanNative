using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayNativeHdrSurfaceCapabilitiesAMD
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 LocalDimmingSupport;
}