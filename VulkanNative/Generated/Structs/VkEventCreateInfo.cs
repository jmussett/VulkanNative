using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkEventCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkEventCreateFlags flags;

    public VkEventCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_EVENT_CREATE_INFO;
    }
}