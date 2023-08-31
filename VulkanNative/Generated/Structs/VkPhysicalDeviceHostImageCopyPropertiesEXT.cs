using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceHostImageCopyPropertiesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public uint copySrcLayoutCount;
    public VkImageLayout* pCopySrcLayouts;
    public uint copyDstLayoutCount;
    public VkImageLayout* pCopyDstLayouts;
    public fixed byte optimalTilingLayoutUUID[(int)VulkanApiConstants.VK_UUID_SIZE];
    public VkBool32 identicalMemoryTypeRequirements;

    public VkPhysicalDeviceHostImageCopyPropertiesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_HOST_IMAGE_COPY_PROPERTIES_EXT;
    }
}