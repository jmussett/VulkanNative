using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorBufferBindingInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceAddress address;
    public VkBufferUsageFlags usage;
}