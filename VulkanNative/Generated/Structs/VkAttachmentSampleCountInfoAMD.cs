using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkAttachmentSampleCountInfoAMD
{
    public VkStructureType SType;
    public void* PNext;
    public uint ColorAttachmentCount;
    public VkSampleCountFlags* PColorAttachmentSamples;
    public VkSampleCountFlags DepthStencilAttachmentSamples;
}