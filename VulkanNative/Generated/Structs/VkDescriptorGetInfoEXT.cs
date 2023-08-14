using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorGetInfoEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkDescriptorType Type;
    public VkDescriptorDataEXT Data;
}