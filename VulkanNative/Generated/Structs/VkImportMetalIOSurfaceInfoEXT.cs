using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMetalIOSurfaceInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public IOSurfaceRef ioSurface;
}