using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkRenderingAreaInfoKHR
{
    public VkStructureType sType;
    public void* pNext;
    public uint viewMask;
    public uint colorAttachmentCount;
    public VkFormat* pColorAttachmentFormats;
    public VkFormat depthAttachmentFormat;
    public VkFormat stencilAttachmentFormat;

    public VkRenderingAreaInfoKHR()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_RENDERING_AREA_INFO_KHR;
    }
}