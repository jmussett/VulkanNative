using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassEndInfo
{
    public VkStructureType sType;
    public void* pNext;

    public VkSubpassEndInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SUBPASS_END_INFO;
    }
}