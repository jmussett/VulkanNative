using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMultisamplePropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkExtent2D maxSampleLocationGridSize;
}