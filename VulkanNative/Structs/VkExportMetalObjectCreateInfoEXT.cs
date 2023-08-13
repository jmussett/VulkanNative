using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalObjectCreateInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkExportMetalObjectTypeFlagsEXT ExportObjectType;
}