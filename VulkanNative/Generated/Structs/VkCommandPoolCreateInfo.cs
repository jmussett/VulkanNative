using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkCommandPoolCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkCommandPoolCreateFlags flags;
    public uint queueFamilyIndex;

    public VkCommandPoolCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_COMMAND_POOL_CREATE_INFO;
    }
}