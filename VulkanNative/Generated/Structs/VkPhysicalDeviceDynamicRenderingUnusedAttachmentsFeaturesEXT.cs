using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 dynamicRenderingUnusedAttachments;

    public VkPhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_DYNAMIC_RENDERING_UNUSED_ATTACHMENTS_FEATURES_EXT;
    }
}