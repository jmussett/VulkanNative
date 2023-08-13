using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceInlineUniformBlockFeatures
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 inlineUniformBlock;
    public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
}