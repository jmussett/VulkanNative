using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetLayoutHostMappingInfoVALVE
{
    public VkStructureType SType;
    public void* PNext;
    public nint DescriptorOffset;
    public uint DescriptorSize;
}