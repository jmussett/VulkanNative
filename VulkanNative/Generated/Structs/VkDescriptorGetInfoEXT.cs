using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorGetInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkDescriptorType type;
    public VkDescriptorDataEXT data;

    public VkDescriptorGetInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_GET_INFO_EXT;
    }
}