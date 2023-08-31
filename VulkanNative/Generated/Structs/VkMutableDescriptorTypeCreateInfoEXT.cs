using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMutableDescriptorTypeCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint mutableDescriptorTypeListCount;
    public VkMutableDescriptorTypeListEXT* pMutableDescriptorTypeLists;

    public VkMutableDescriptorTypeCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MUTABLE_DESCRIPTOR_TYPE_CREATE_INFO_EXT;
    }
}