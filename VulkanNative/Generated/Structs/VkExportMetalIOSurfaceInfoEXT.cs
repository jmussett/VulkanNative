using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalIOSurfaceInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkImage image;
    public IOSurfaceRef ioSurface;
}