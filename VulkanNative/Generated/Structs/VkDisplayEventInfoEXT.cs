using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDisplayEventInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDisplayEventTypeEXT displayEvent;

    public VkDisplayEventInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DISPLAY_EVENT_INFO_EXT;
    }
}