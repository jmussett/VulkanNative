using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFormatProperties2
{
    public VkStructureType sType;
    public void* pNext;
    public VkFormatProperties formatProperties;

    public VkFormatProperties2()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_FORMAT_PROPERTIES_2;
    }
}