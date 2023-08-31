using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceLinearColorAttachmentFeaturesNV
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 linearColorAttachment;

    public VkPhysicalDeviceLinearColorAttachmentFeaturesNV()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_LINEAR_COLOR_ATTACHMENT_FEATURES_NV;
    }
}