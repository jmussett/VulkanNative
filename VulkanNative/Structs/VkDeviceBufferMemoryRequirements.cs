using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDeviceBufferMemoryRequirements
{
    public VkStructureType sType;
    public void* pNext;
    public VkBufferCreateInfo* pCreateInfo;
}