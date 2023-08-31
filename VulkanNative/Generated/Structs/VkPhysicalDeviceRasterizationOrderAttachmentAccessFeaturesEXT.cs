using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT
{
    public VkStructureType sType;
    public void* pNext;
    public VkBool32 rasterizationOrderColorAttachmentAccess;
    public VkBool32 rasterizationOrderDepthAttachmentAccess;
    public VkBool32 rasterizationOrderStencilAttachmentAccess;
}