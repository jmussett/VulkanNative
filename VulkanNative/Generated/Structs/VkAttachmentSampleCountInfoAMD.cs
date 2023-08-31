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
}