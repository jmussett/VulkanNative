using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceBufferMemoryRequirements
{
    public VkStructureType sType;
    public void* pNext;
    public VkBufferCreateInfo* pCreateInfo;

    public VkDeviceBufferMemoryRequirements()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_BUFFER_MEMORY_REQUIREMENTS;
    }
}