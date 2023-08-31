using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassBeginInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkSubpassContents contents;

    public VkSubpassBeginInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_SUBPASS_BEGIN_INFO;
    }
}