using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalObjectsInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
}