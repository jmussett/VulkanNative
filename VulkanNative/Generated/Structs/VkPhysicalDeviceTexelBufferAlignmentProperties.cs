using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceTexelBufferAlignmentProperties
{
    public VkStructureType sType;
    public void* pNext;
    public VkDeviceSize storageTexelBufferOffsetAlignmentBytes;
    public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;
    public VkDeviceSize uniformTexelBufferOffsetAlignmentBytes;
    public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;

    public VkPhysicalDeviceTexelBufferAlignmentProperties()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_PROPERTIES;
    }
}