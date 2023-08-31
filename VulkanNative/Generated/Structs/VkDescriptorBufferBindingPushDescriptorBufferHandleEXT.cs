using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorBufferBindingPushDescriptorBufferHandleEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBuffer buffer;

    public VkDescriptorBufferBindingPushDescriptorBufferHandleEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_BUFFER_BINDING_PUSH_DESCRIPTOR_BUFFER_HANDLE_EXT;
    }
}