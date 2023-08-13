using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetLayoutBindingFlagsCreateInfo
{
    public VkStructureType sType;
    public void* pNext;
    public uint bindingCount;
    public VkDescriptorBindingFlags* pBindingFlags;
}