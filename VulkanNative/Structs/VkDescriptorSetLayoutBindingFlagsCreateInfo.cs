using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfo
{
    public VkStructureType SType;
    public void* PNext;
    public uint BindingCount;
    public VkDescriptorBindingFlags* PBindingFlags;
}