using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMetalIOSurfaceInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public IOSurfaceRef IoSurface;
}