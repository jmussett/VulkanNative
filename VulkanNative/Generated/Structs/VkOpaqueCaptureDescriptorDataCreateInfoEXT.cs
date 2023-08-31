using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkOpaqueCaptureDescriptorDataCreateInfoEXT
{
    public VkStructureType sType;
    public void* pNext;
    public void* opaqueCaptureDescriptorData;

    public VkOpaqueCaptureDescriptorDataCreateInfoEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_OPAQUE_CAPTURE_DESCRIPTOR_DATA_CREATE_INFO_EXT;
    }
}