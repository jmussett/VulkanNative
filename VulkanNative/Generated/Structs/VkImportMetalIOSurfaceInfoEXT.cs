using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMetalIOSurfaceInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public IOSurfaceRef ioSurface;

    public VkImportMetalIOSurfaceInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_IMPORT_METAL_IO_SURFACE_INFO_EXT;
    }
}