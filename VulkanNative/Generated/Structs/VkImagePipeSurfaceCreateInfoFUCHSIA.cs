using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImagePipeSurfaceCreateInfoFUCHSIA
{
    public VkStructureType sType;
    public void* pNext;
    public VkImagePipeSurfaceCreateFlagsFUCHSIA flags;
    public nint imagePipeHandle;

    public VkImagePipeSurfaceCreateInfoFUCHSIA()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMAGEPIPE_SURFACE_CREATE_INFO_FUCHSIA;
    }
}