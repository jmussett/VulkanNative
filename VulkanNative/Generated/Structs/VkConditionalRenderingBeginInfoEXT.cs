using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkConditionalRenderingBeginInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBuffer Buffer;
    public VkDeviceSize Offset;
    public VkConditionalRenderingFlagsEXT Flags;
}