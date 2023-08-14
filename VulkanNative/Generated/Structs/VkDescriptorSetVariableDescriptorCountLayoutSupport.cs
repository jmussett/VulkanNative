using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkDescriptorSetVariableDescriptorCountLayoutSupport
{
    public VkStructureType SType;
    public void* PNext;
    public uint MaxVariableDescriptorCount;
}