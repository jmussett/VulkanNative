using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMutableDescriptorTypeListEXT
{
    public uint descriptorTypeCount;
    public VkDescriptorType* pDescriptorTypes;
}