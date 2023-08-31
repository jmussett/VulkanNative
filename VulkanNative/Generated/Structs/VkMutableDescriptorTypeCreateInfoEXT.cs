using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMutableDescriptorTypeCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint mutableDescriptorTypeListCount;
    public VkMutableDescriptorTypeListEXT* pMutableDescriptorTypeLists;
}