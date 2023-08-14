using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceInlineUniformBlockFeatures
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 InlineUniformBlock;
    public VkBool32 DescriptorBindingInlineUniformBlockUpdateAfterBind;
}