using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExternalMemoryImageCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public VkExternalMemoryHandleTypeFlags HandleTypes;
}