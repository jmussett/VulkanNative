using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkStreamDescriptorSurfaceCreateInfoGGP
{
    public VkStructureType SType;
    public void* PNext;
    public VkStreamDescriptorSurfaceCreateFlagsGGP Flags;
    public nint StreamDescriptor;
}