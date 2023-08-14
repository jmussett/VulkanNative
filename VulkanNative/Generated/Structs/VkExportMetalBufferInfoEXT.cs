using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkExportMetalBufferInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkDeviceMemory Memory;
    public MTLBuffer_id MtlBuffer;
}