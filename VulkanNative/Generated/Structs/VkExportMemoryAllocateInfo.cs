using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMemoryAllocateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkExternalMemoryHandleTypeFlags HandleTypes;
}