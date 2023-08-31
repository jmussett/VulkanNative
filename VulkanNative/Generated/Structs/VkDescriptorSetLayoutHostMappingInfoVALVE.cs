using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetLayoutHostMappingInfoVALVE
{
    public VkStructureType sType;
    public void* pNext;
    public nuint descriptorOffset;
    public uint descriptorSize;
}