using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetLayoutHostMappingInfoVALVE
{
    public VkStructureType SType;
    public void* PNext;
    public nuint DescriptorOffset;
    public uint DescriptorSize;
}