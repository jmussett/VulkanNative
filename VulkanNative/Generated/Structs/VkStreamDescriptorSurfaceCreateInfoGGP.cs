using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkStreamDescriptorSurfaceCreateInfoGGP
{
    public VkStructureType sType;
    public void* pNext;
    public VkStreamDescriptorSurfaceCreateFlagsGGP flags;
    public nint streamDescriptor;
}