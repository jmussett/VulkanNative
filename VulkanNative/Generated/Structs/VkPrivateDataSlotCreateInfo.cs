using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPrivateDataSlotCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public VkPrivateDataSlotCreateFlags flags;

    public VkPrivateDataSlotCreateInfo()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PRIVATE_DATA_SLOT_CREATE_INFO;
    }
}