using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkFenceCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkFenceCreateFlags flags;

    public VkFenceCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_FENCE_CREATE_INFO;
    }
}