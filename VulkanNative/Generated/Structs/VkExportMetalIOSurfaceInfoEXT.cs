using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalIOSurfaceInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkImage image;
    public IOSurfaceRef ioSurface;

    public VkExportMetalIOSurfaceInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_EXPORT_METAL_IO_SURFACE_INFO_EXT;
    }
}