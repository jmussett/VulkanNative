using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT
{
    public VkStructureType SType;
    public void* PNext;
    public VkBool32 RasterizationOrderColorAttachmentAccess;
    public VkBool32 RasterizationOrderDepthAttachmentAccess;
    public VkBool32 RasterizationOrderStencilAttachmentAccess;
}