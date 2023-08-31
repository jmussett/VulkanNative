using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetLayoutSupport
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 supported;

    public VkDescriptorSetLayoutSupport()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_SUPPORT;
    }
}