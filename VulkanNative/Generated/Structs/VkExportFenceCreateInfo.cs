using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportFenceCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkExternalFenceHandleTypeFlags HandleTypes;
}