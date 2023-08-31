using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 texelBufferAlignment;

    public VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_FEATURES_EXT;
    }
}