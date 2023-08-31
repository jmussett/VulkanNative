using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetLayoutHostMappingInfoVALVE
{
    public VkStructureType sType;
    public void* pNext;
    public nuint descriptorOffset;
    public uint descriptorSize;

    public VkDescriptorSetLayoutHostMappingInfoVALVE()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_HOST_MAPPING_INFO_VALVE;
    }
}