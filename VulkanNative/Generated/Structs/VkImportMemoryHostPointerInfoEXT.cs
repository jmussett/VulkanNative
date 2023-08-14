using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMemoryHostPointerInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkExternalMemoryHandleTypeFlags HandleType;
    public void* PHostPointer;
}