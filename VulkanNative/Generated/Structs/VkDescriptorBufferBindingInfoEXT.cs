using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorBufferBindingInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceAddress address;
    public VkBufferUsageFlags usage;

    public VkDescriptorBufferBindingInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_INFO_EXT;
    }
}