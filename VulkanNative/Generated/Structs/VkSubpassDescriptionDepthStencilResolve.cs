using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassDescriptionDepthStencilResolve
{
    public VkStructureType SType;
    public void* PNext;
    public VkResolveModeFlags DepthResolveMode;
    public VkResolveModeFlags StencilResolveMode;
    public VkAttachmentReference2* PDepthStencilResolveAttachment;
}