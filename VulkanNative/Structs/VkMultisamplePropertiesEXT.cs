using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMultisamplePropertiesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkExtent2D MaxSampleLocationGridSize;
}