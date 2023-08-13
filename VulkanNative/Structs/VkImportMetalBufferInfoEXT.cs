using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkImportMetalBufferInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public MTLBuffer_id MtlBuffer;
}