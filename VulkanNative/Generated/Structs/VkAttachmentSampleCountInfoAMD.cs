using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAttachmentSampleCountInfoAMD
{
    public VkStructureType sType;
    public void* pNext;
    public uint colorAttachmentCount;
    public VkSampleCountFlags* pColorAttachmentSamples;
    public VkSampleCountFlags depthStencilAttachmentSamples;

    public VkAttachmentSampleCountInfoAMD()
    {
        sType = VkStructureType.VK_STRUCTURE_TYPE_ATTACHMENT_SAMPLE_COUNT_INFO_AMD;
    }
}