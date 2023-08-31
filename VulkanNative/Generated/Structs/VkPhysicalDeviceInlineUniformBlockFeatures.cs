using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceInlineUniformBlockFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 inlineUniformBlock;
    public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;

    public VkPhysicalDeviceInlineUniformBlockFeatures()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_INLINE_UNIFORM_BLOCK_FEATURES;
    }
}