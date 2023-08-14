using System.Runtime.InteropServices;

namespace VulkanNative;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct VkSubpassShadingPipelineCreateInfoHUAWEI
{
    public VkStructureType SType;
    public void* PNext;
    public VkRenderPass RenderPass;
    public uint Subpass;
}