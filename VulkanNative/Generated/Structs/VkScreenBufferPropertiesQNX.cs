using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkScreenBufferPropertiesQNX
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceSize allocationSize;
    public uint memoryTypeBits;

    public VkScreenBufferPropertiesQNX()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SCREEN_BUFFER_PROPERTIES_QNX;
    }
}