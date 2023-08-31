using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkMultisamplePropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkExtent2D maxSampleLocationGridSize;

    public VkMultisamplePropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_MULTISAMPLE_PROPERTIES_EXT;
    }
}