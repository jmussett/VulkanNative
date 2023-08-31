using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkConditionalRenderingBeginInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBuffer buffer;
    public VkDeviceSize offset;
    public VkConditionalRenderingFlagsEXT flags;
}