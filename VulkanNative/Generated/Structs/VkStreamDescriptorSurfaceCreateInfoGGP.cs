using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkStreamDescriptorSurfaceCreateInfoGGP
{
    public VkStructureType sType;
    public void* pNext;
    public VkStreamDescriptorSurfaceCreateFlagsGGP flags;
    public nint streamDescriptor;

    public VkStreamDescriptorSurfaceCreateInfoGGP()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_STREAM_DESCRIPTOR_SURFACE_CREATE_INFO_GGP;
    }
}