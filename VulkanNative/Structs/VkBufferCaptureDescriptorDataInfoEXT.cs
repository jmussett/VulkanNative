using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkBufferCaptureDescriptorDataInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBuffer Buffer;
}