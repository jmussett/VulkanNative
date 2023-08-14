using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImagePipeSurfaceCreateInfoFUCHSIA
{
    public VkStructureType SType;
    public void* PNext;
    public VkImagePipeSurfaceCreateFlagsFUCHSIA Flags;
    public nint ImagePipeHandle;
}